namespace DIO.dotnet.Entities
{
    public class Imovel
    {
        public string Endereco {get; set; }
        public string Cidade {get; set; }
        public int Metragem {get; set; }
        public byte qtdQuartos {get; set; }
        public int valorImovel {get; set; } 
        
       


        public Imovel(string Endereco, string Cidade, int Metragem, byte qtdQuartos, int valorImovel)
        {
            this.Endereco = Endereco;
            this.Cidade = Cidade;
            this.Metragem = Metragem;
            this.qtdQuartos = qtdQuartos;
            this.valorImovel = valorImovel;
            //não preciso colocar no construtor para pedir instanciação obrigatoria na hora da criação do obj, pq ja tenho valor atribuido
        }

        public virtual double taxaCorretor(){
            return valorImovel * 1.1;
        }
        public override string ToString(){          //sobre escrever o método para retornar as informações que queira
            return "Cidade: " + Cidade +"\n"+
                         "Endereço:" + Endereco+"\n"+
                         "Metragem(m):" + Metragem+"\n"+ 
                         "Quartos:" + qtdQuartos+"\n"+
                         "Valor:" + valorImovel+"\n"+
                         "Valor com a Taxa:" + taxaCorretor();

        }

    }
}