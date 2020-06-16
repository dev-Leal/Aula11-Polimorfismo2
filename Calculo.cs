namespace Aula_11__Polimorfismo_2
{
    public class Calculo
    {
       public string Calcular (){

            return "Não houve nenhum calculo a ser aplicado";
       }

       public string Calcular (int vida){

           return "A vida do seu jogador é de "+vida;
       }

       public string Calcular (int vida, int dano){

           return "O dano do seu jogador é "+ (dano);
       }

       public string Calcular (int vida, int dano, int especial){

           return "O dano do seu jogador com o especial é "+ (dano+especial);
       }

       public string Calcular (int vida, int dano, int especial, string nome){

           return $"Você está jogando com o personagem {nome}";
       }




    }
}