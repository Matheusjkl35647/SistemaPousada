using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula19Projetofinal_6320048
{
    class Quarto
    {
        private int numero;
        private string tipoQuarto;
        private string descricao;

        public Quarto()
        {
            Numero = 0;
            TipoQuarto = "";
            Descricao = "";
        }

        public Quarto(int n, string tq, string d)
        {
            Numero = n;
            TipoQuarto = tq;
            Descricao = d;
        }

        public string CaminhoQuarto()
        {
            return "C:/Users/Mathe/desktop/Aula19_RAA6320048Quarto.txt"; 

        }

        public void Gravar()
        {
            // Usa a classe StreamWriter para grava em txt baseado no caminho que foi lhe passado e cria o arquivo, caso não exista.
            StreamWriter swriter = File.AppendText(CaminhoQuarto());
            // Aqui informamos como os dados serão armazenados dentro do arquivo txt
            swriter.WriteLine(this.Numero + ";" + this.TipoQuarto + ";" + this.Descricao + ";");
            //Agora fechamos o programa
            swriter.Close();
        }

        public List<Quarto> LerQuarto()
        {
            var list = new List<Quarto>();
            // Verifica se o arquivo existe {Exists}
            if (File.Exists(CaminhoQuarto()))
            {
                //Usa o StreamReader para fazer a leitura do arquivo baseado no caminho
                StreamReader sreader = File.OpenText(CaminhoQuarto());
                string linha;
                while ((linha = sreader.ReadLine()) != null)
                {
                    var arquivo = linha.Split(';');
                    Quarto quarto = new Quarto(int.Parse(arquivo[0]), arquivo[1], arquivo[2]);
                    list.Add(quarto);
                }
                sreader.Close();
            }
            return list;
        }
            //Abaixos sobre-escrevemos sob os dados já inclusos

            public void AtualizarQuarto()
            {
                string text = null;
                if (File.Exists(CaminhoQuarto()))
                {
                    using (StreamReader sreader = new StreamReader(CaminhoQuarto()))
                    {
                        string linha;
                        while ((linha = sreader.ReadLine()) != null)
                        {
                            var arquivo = linha.Split(';');
                            if (arquivo[0].Equals(this.Numero) || arquivo[1].Equals(this.TipoQuarto) || (arquivo[2].Equals(this.Descricao)))
                            {
                                string novoTexto = this.Numero + ";" + this.TipoQuarto + ";" + this.Descricao + "\n";
                                text += novoTexto;
                            }
                            else
                            {
                                text = text + linha + "\n";
                            }
                        }
                        sreader.Close();
                        File.Delete(CaminhoQuarto());
                        StreamWriter swriter = new StreamWriter(CaminhoQuarto());
                        swriter.Write(text);
                        swriter.Close();
                    }
                }

            }

            // Toda informãção abaixo irá apagar os dados Inclusos no determinado local

            public void ExcluirQuarto()
            {
                string text = null;
                if (File.Exists(CaminhoQuarto()))
                {
                    using (StreamReader sreader = new StreamReader(CaminhoQuarto()))
                    {
                        string linha;
                        while ((linha = sreader.ReadLine()) != null)
                        {
                            var arquivo = linha.Split(';');
                            if (!arquivo[0].Equals(this.Numero.ToString()))
                            {
                                text = text + linha + "\n";
                            }
                        }
                        sreader.Close();
                        File.Delete(CaminhoQuarto());
                        StreamWriter swriter = new StreamWriter(CaminhoQuarto());
                        swriter.Write(text);
                        swriter.Close();
                    }
                }
            }

            // Abaixo buscarémos na lista com o nome informado;

            public void Buscar()
            {
                if (File.Exists(CaminhoQuarto()))
                {
                    StreamReader sreader = File.OpenText(CaminhoQuarto());
                    string linha;
                    while ((linha = sreader.ReadLine()) != null)
                    {
                        var arquivo = linha.Split(';');
                        if (arquivo[0].Equals(this.Numero.ToString()))
                        {
                            TipoQuarto = arquivo[1];
                            Descricao = arquivo[2];
                        }
                    }
                    sreader.Close();
                }
            }

        public int Numero { get => numero; set => numero = value; }
        public string TipoQuarto { get => tipoQuarto; set => tipoQuarto = value; }
        public string Descricao { get => descricao; set => descricao = value; }
    }
}

