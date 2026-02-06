using ExerciciosPooCsharp._11TopicosEspeciaisC_Parte2.Topicos2.Extensions;
//metodo para estender
/* Vamos criar um extension method chamado "ElapsedTime()" no struct DateTime para apresentar um objeto DateTime na forma de tempo
decorrido, podendo ser em horas (se menor que 24h) ou em dias caso contrário. Por exemplo:
DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);
Console.WriteLine(dt.ElapsedTime());
"4.5 hours"
"3.2 days" */
namespace ExerciciosPooCsharp._11TopicosEspeciaisC_Parte2.Topicos2
{
    internal class Topicos2
    {
        public static void Executar()
        {
            DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());


        }
    }
}
