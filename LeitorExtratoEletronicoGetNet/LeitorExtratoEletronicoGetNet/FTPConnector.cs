using Flunt.Notifications;
using LeitorExtratoEletronicoGetNet.Modelos;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeitorExtratoEletronicoGetNet
{
    public class FTPConnector : Notifiable
    {
        private string url;
        private int porta;
        private string usuario;
        private string senha;
        private string diretorio;
        private LeitorArquivo leitor;

        public FTPConnector(string url, int porta, string usuario, string senha, string diretorio = "/publico")
        {
            this.url = url;
            this.porta = porta;
            this.usuario = usuario;
            this.senha = senha;
            this.diretorio = diretorio;
            this.leitor = new LeitorArquivo();
        }

        public List<ArquivoGetNet> LerArquivosAposAData(DateTime dataEscritaArquivo)
        {
            var arquivosGetNet = new List<ArquivoGetNet>();

            using (var sftp = new SftpClient(url, porta, usuario, senha))
            {
                try
                {
                    sftp.Connect();
                    var arquivos = sftp.ListDirectory(this.diretorio).Where(x => x.IsRegularFile && !x.IsDirectory && x.LastWriteTime >= dataEscritaArquivo).ToList();

                    foreach (var arquivo in arquivos)
                    {
                        var retorno = sftp.ReadLines(arquivo.FullName);
                        var arquivoGetNet = new ArquivoGetNet
                        {
                            DataArquivo = arquivo.LastWriteTime,
                            NomeArquivo = arquivo.Name,
                        };

                        retorno.ToList().ForEach(x =>
                        {
                            var tipoLinha = x[0];
                            switch (tipoLinha)
                            {
                                case '9':
                                    arquivoGetNet.Trailer = leitor.LerLinha<TrailerArquivo>(x);
                                    break;
                                case '4':
                                    arquivoGetNet.DetalheOperacaoAntecipacao.Add(leitor.LerLinha<DetalheOperacaoAntecipacao>(x));
                                    break;
                                case '3':
                                    arquivoGetNet.Ajustes.Add(leitor.LerLinha<Ajustes>(x));
                                    break;
                                case '2':
                                    arquivoGetNet.DetalheComprovanteVenda.Add(leitor.LerLinha<DetalheComprovanteVenda>(x));
                                    break;
                                case '1':
                                    arquivoGetNet.DetalheResumoVenda.Add(leitor.LerLinha<DetalheResumoVenda>(x));
                                    break;
                                case '0':
                                    arquivoGetNet.Header = leitor.LerLinha<Header>(x);
                                    break;
                                default:
                                    break;
                            }
                        });

                        arquivosGetNet.Add(arquivoGetNet);
                    }
                }
                catch (Exception)
                {
                }
                finally
                {
                    sftp.Disconnect();
                }

                return arquivosGetNet;
            }
        }
    }
}
