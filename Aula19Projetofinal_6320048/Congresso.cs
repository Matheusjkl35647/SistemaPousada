using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula19Projetofinal_6320048
{
    class Congresso : Reservar
    {
        private string localCongresso;
        private int valorCongresso;

        public Congresso() : base()
        {
            LocalCongresso = "";
            ValorCongresso = 0;
        }

        public Congresso(string n, string c, string t, string dte, string dts, string lc, int vc) : base(n, c, t, dte, dts)
        {
            LocalCongresso = lc;
            ValorCongresso = vc;
        }

        public string LocalCongresso { get => localCongresso; set => localCongresso = value; }
        public int ValorCongresso { get => valorCongresso; set => valorCongresso = value; }

        public new void Gravar()
        {
            // Usa a classe StreamWriter para grava em txt baseado no caminho que foi lhe passado e cria o arquivo, caso não exista.
            StreamWriter swriter = File.AppendText(Caminho());
            // Aqui informamos como os dados serão armazenados dentro do arquivo txt
            swriter.WriteLine(this.NomeReserva + ";" + this.CpfReserva + ";" + this.TipoQuartoReserva + ";" +
                this.DataEntradaReserva + ";" + this.DataSaidaReserva + ";" +
                         this.LocalCongresso + ";" + this.ValorCongresso);
            //Agora fechamos o programa
            swriter.Close();
        }

        public new List<Congresso> Ler()
        {
            var list = new List<Congresso>();
            // Verifica se o arquivo existe {Exists}
            if (File.Exists(Caminho()))
            {
                //Usa o StreamReader para fazer a leitura do arquivo baseado no caminho
                StreamReader sreader = File.OpenText(Caminho());
                string linha;
                while ((linha = sreader.ReadLine()) != null)
                {
                    var arquivo = linha.Split(';');
                    if (arquivo.Length == 7)
                    {
                        Congresso congresso = new Congresso(arquivo[0], arquivo[1], arquivo[2],
                                                             arquivo[3], arquivo[4], arquivo[5], int.Parse(arquivo[6]));
                        list.Add(congresso);
                    }
                    else
                    {
                        Congresso congresso = new Congresso(arquivo[0], arquivo[1], arquivo[2],
                                                             arquivo[3], arquivo[4], "", 0);
                        list.Add(congresso);
                    }

                }
                sreader.Close();
            }
            return list;
        }

        public new void Atualizar()
        {
            string texto = null;
            if (File.Exists(Caminho()))
            {
                using (StreamReader sr = new StreamReader(Caminho()))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        var arquivo = linha.Split(';');
                        if (arquivo[0].Equals(this.NomeReserva))
                        {
                            string nova = this.NomeReserva + ";" + this.CpfReserva + ";" + this.TipoQuartoReserva + ";" +
                                          this.DataEntradaReserva + ";" + this.DataSaidaReserva + ";" +
                                          this.LocalCongresso + ";" + this.ValorCongresso + "\n";
                            texto = texto + nova;
                        }
                        else
                        {
                            texto = texto + linha + "\n";
                        }
                    }
                    sr.Close();
                    File.Delete(Caminho());
                    StreamWriter sw = new StreamWriter(Caminho());
                    sw.Write(texto);
                    sw.Close();
                }
            }
        }

        public new void Excluir()
        {
            string texto = null;
            if (File.Exists(Caminho()))
            {
                using (StreamReader sr = new StreamReader(Caminho()))
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
                    File.Delete(Caminho());
                    StreamWriter sw = new StreamWriter(Caminho());
                    sw.Write(texto);
                    sw.Close();
                }
            }
        }

        public void Busca()
        {
            if (File.Exists(Caminho()))
            {
                StreamReader sr = File.OpenText(Caminho());
                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    var arquivo = linha.Split(';');
                    if (arquivo[5].Equals(this.LocalCongresso))
                    {
                        NomeReserva = arquivo[0];
                        CpfReserva = arquivo[1];
                        TipoQuartoReserva = arquivo[2];
                        DataEntradaReserva = arquivo[3];
                        DataSaidaReserva = arquivo[4];
                        ValorCongresso = int.Parse(arquivo[6]);
                    }
                }
                sr.Close();
            }
        }

    }
}
