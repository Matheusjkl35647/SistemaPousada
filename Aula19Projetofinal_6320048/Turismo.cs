using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula19Projetofinal_6320048 
{
    class Turismo : Reservar
    {
        private string nomePasseio;
        private string dataPasseio;

        public Turismo() : base()
        {
            NomePasseio = "Funciona código, pelo amor de Deus";
            DataPasseio = "01/12/2020";
        }
        
        public Turismo(string n, string c, string t, string dte, string dts, string np, string dt) : base(n, c, t, dte,dts)
        {
            NomePasseio = np;
            DataPasseio = dt;
        }

        public string NomePasseio { get => nomePasseio; set => nomePasseio = value; }
        public string DataPasseio { get => dataPasseio; set => dataPasseio = value; }

        public new void Gravar()
        {
            // Usa a classe StreamWriter para grava em txt baseado no caminho que foi lhe passado e cria o arquivo, caso não exista.
            StreamWriter swriter = File.AppendText(Caminho1());
            // Aqui informamos como os dados serão armazenados dentro do arquivo txt
            swriter.WriteLine(this.NomeReserva + ";" + this.CpfReserva + ";" + this.TipoQuartoReserva + ";" + this.DataEntradaReserva + ";"
                              + this.DataSaidaReserva + ";" + this.NomePasseio + ";" + this.DataPasseio);
            //Agora fechamos o programa
            swriter.Close();
        }

        public new List<Turismo> Ler()
        {
            var list = new List<Turismo>();
            // Verifica se o arquivo existe {Exists}
            if (File.Exists(Caminho1()))
            {
                //Usa o StreamReader para fazer a leitura do arquivo baseado no caminho
                StreamReader sreader = File.OpenText(Caminho1());
                string linha;
                while ((linha = sreader.ReadLine()) != null)
                {
                    var arquivo = linha.Split(';');
                    if(arquivo.Length == 7)
                    {
                        Turismo turismo = new Turismo(arquivo[0], arquivo[1], arquivo[2], arquivo[3], arquivo[4], arquivo[5], arquivo[6]);
                        list.Add(turismo);
                    } else
                    {
                        Turismo turismo = new Turismo(arquivo[0], arquivo[1], arquivo[2], arquivo[3], arquivo[4], "m", "78/78/2020");
                        list.Add(turismo);
                    }
                    
                }
                sreader.Close();
            }
            return list;
        }

        public new void Atualizar()
        {
            string texto = null;
            if (File.Exists(Caminho1()))
            {
                using (StreamReader sr = new StreamReader(Caminho1()))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        var arquivo = linha.Split(';');
                        if (arquivo[0].Equals(this.NomeReserva))
                        {
                            string nova = this.NomeReserva + ";" + this.CpfReserva + ";" + this.TipoQuartoReserva + ";" +
                                          this.DataEntradaReserva + ";" + this.DataSaidaReserva + ";" +
                                           ";" + this.NomePasseio + ";" + this.DataPasseio + "\n";
                            texto = texto + nova;
                        }
                        else
                        {
                            texto = texto + linha + "\n";
                        }
                    }
                    sr.Close();
                    File.Delete(Caminho1());
                    StreamWriter sw = new StreamWriter(Caminho1());
                    sw.Write(texto);
                    sw.Close();
                }
            }
        }

        public new void Excluir()
        {
            string texto = null;
            if (File.Exists(Caminho1()))
            {
                using (StreamReader sr = new StreamReader(Caminho1()))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        var arquivo = linha.Split(';');
                        if (!arquivo[0].Equals(this.NomeReserva))
                        {
                            texto = texto + linha + "\n";
                        }
                    }
                    sr.Close();
                    File.Delete(Caminho1());
                    StreamWriter sw = new StreamWriter(Caminho1());
                    sw.Write(texto);
                    sw.Close();
                }
            }
        }

        public void Busca1()
        {
            if (File.Exists(Caminho1()))
            {
                StreamReader sr = File.OpenText(Caminho1());
                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    var arquivo = linha.Split(';');
                    if (arquivo[5].Equals(this.NomePasseio))
                    {
                        NomeReserva = arquivo[0];
                        CpfReserva = arquivo[1];
                        TipoQuartoReserva = arquivo[2];
                        DataEntradaReserva = arquivo[3];
                        DataSaidaReserva = arquivo[4];
                        DataPasseio = arquivo[6];

                    }
                }
                sr.Close();
            }
        }

    }
}
