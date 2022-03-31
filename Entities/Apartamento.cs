namespace DIO.dotnet.Entities
{
    public class Apartamento : Imovel   //Herdar
    {
        public Apartamento(string Endereco, string Cidade, int Metragem, byte qtdQuartos, int valorImovel, byte Andar, string numeroApartamento, string Bloco) : base(Endereco, Cidade, Metragem, qtdQuartos, valorImovel)
        {
            this.Andar = Andar;
            this.numeroApartamento = numeroApartamento;
            this.Bloco = Bloco;
        }

        public byte Andar {get; set;}
        public string numeroApartamento{get;set;}
        public string Bloco{get;set;}
        public override double taxaCorretor(){
            return valorImovel * 1.2;
        }

        public override string ToString(){          //sobre escrever o método para retornar as informações que queira
                        return "Cidade: " + Cidade +"\n"+
                         "Endereço:" + Endereco+"\n"+
                         "Metragem(m):" + Metragem+"\n"+ 
                         "Quartos:" + qtdQuartos+"\n"+
                         "Andar:" + Andar+"\n"+
                         "Numero do Apartamento:" + numeroApartamento+"\n"+
                         "Bloco:" + Bloco+"\n"+
                         "Valor:" + valorImovel+"\n"+
                         "Valor com a Taxa:" + taxaCorretor();
        }

    }
}