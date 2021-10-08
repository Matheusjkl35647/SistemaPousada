using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula19Projetofinal_6320048
{
    class Reservar
    {
        private string nomeReserva;
        private string cpfReserva;
        private string tipoQuartoReserva;
        private string dataEntradaReserva;
        private string dataSaidaReserva;

        public Reservar()
        {
            NomeReserva = "";
            CpfReserva = "";
            TipoQuartoReserva = "";
            DataEntradaReserva = "";
            DataSaidaReserva = "";
           
        }

        public Reservar(string n, string c, string t, string dte, string dts)
        {
            NomeReserva = n;
            CpfReserva = c;
            TipoQuartoReserva = t;
            DataEntradaReserva = dte;
            DataSaidaReserva = dts;
        }

        public string NomeReserva { get => nomeReserva; set => nomeReserva = value; }
        public string CpfReserva { get => cpfReserva; set => cpfReserva = value; }
        public string TipoQuartoReserva { get => tipoQuartoReserva; set => tipoQuartoReserva = value; }
        public string DataEntradaReserva { get => dataEntradaReserva; set => dataEntradaReserva = value; }
        public string DataSaidaReserva { get => dataSaidaReserva; set => dataSaidaReserva = value; }

        public string Caminho()
        {
            return "C:/Users/Mathe/Desktop/teste.txt";
        }

        public string Caminho1()
        {
            return "C:/Users/Mathe/Desktop/teste1.txt";
        }

        public string Caminho2()
        {
            return "C:/Users/Mathe/Desktop/teste2.txt";
        }


        public void Gravar()
        {
            // Usa a classe StreamWriter para grava em txt baseado no caminho que foi lhe passado e cria o arquivo, caso não exista.
            StreamWriter swriter = File.AppendText(Caminho2());
            // Aqui informamos como os dados serão armazenados dentro do arquivo txt
            swriter.WriteLine(this.NomeReserva + ";" + this.CpfReserva + ";" + 
                         this.TipoQuartoReserva + ";" + this.DataEntradaReserva + ";" + this.DataSaidaReserva);
            //Agora fechamos o programa
            swriter.Close();
        }

        public List<Reservar> Ler()
        {
            var list = new List<Reservar>();
            // Verifica se o arquivo existe {Exists}
            if (File.Exists(Caminho2()))
            {
                //Usa o StreamReader para fazer a leitura do arquivo baseado no caminho
                StreamReader sreader = File.OpenText(Caminho2());
                string linha;
                while((linha = sreader.ReadLine()) != null) 
                {
                    var arquivo = linha.Split(';');
                    Reservar reserva = new Reservar(arquivo[0], arquivo[1], arquivo[2], arquivo[3], arquivo[4]);
                    list.Add(reserva);
                }
                sreader.Close();
            }
            return list;
        }

        public void Atualizar()
        {
            string texto = null;
            if (File.Exists(Caminho2()))
            {
                using (StreamReader sr = new StreamReader(Caminho2()))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        var arquivo = linha.Split(';');
                        if (arquivo[0].Equals(this.NomeReserva))
                        {
                            string nova = this.NomeReserva + ";" + this.CpfReserva + ";" + this.TipoQuartoReserva + ";" + 
                                          this.DataEntradaReserva + ";" + this.DataSaidaReserva + "\n";
                            texto = texto + nova;
                        }
                        else
                        {
                            texto = texto + linha + "\n";
                        }
                    }
                    sr.Close();
                    File.Delete(Caminho2());
                    StreamWriter sw = new StreamWriter(Caminho2());
                    sw.Write(texto);
                    sw.Close();
                }
            }
        }

        public void Excluir()
        {
            string texto = null;
            if (File.Exists(Caminho2()))
            {
                using (StreamReader sr = new StreamReader(Caminho2()))
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
                    File.Delete(Caminho2());
                    StreamWriter sw = new StreamWriter(Caminho2());
                    sw.Write(texto);
                    sw.Close();
                }
            }
        }

        public void Busca2()
        {
            if (File.Exists(Caminho2()))
            {
                StreamReader sr = File.OpenText(Caminho2());
                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    var arquivo = linha.Split(';');
                    if (arquivo[1].Equals(this.CpfReserva))
                    {
                        NomeReserva = arquivo[0];
                        TipoQuartoReserva = arquivo[2];
                        DataEntradaReserva = arquivo[3];
                        DataSaidaReserva = arquivo[4];
                    }
                }
                sr.Close();
            }
        }


    }


}

