using System;
using System.Globalization;

namespace ExerciciosPooCsharp._4TopicosEspeciaisC_Parte1
{
    internal class Topicos
    {
        public static void Executar()
        {
            Console.WriteLine("1) Palavra var: ");
            Console.WriteLine("int x = 10 ou var y = 11;");
            Console.WriteLine(" a própria palavra var ja indentifica ou infere o tipo da variavel");
            
            Console.WriteLine("\n=====================================================================");

            Console.WriteLine("\n2) Sintaxe alternativa: switch-case:" +
                " Estrutura opcional a vários if-else encadeados, quando a condição envolve o teste\r\ndo valor de uma variável.");

            /*int x = int.Parse(Console.ReadLine());
            string day;
            if (x == 1)
            {
                day = "Sunday";
            }
            else if (x == 2)
            {
                day = "Monday";
            }
            else if (x == 3)
            {
                day = "Tuesday";
            }
            else if (x == 4)
            {
                day = "Wednesday";
            }
            else if (x == 5)
            {
                day = "Thursday";
            }
            else if (x == 6)
            {
                day = "Friday";
            }
            else if (x == 7)
            {
                day = "Saturday";
            }
            else
            {
                day = "Invalid value";
            }
            Console.WriteLine("Day: " + day);*/

            Console.WriteLine("OU, obs: olhar os comentarios no programa topicos.cs");
            /*int x = int.Parse(Console.ReadLine());
            string day;
            switch (x) {
                case 1:
                    day = "Sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                case 4:
                    day = "Wednesday";
                    break;
                case 5:
                    day = "Thursday";
                    break;
                case 6:
                    day = "Friday";
                    break;
                case 7:
                    day = "Saturday";
                    break;
                default:
                    day = "Invalid value";
                    break;
            }
            Console.WriteLine("Day: " + day);*/
            Console.WriteLine("\n=====================================================================");

            Console.WriteLine("3) Estrutura condicional ternaria: ");
            Console.WriteLine("Estrutura opcional ao if-else quando se deseja decidir um VALOR com base em uma\r\ncondição.");
            /*Sintaxe:
            ( condição ) ? valor_se_verdadeiro : valor_se_falso
            ( 2 > 4 ) ? 50 : 80
            Exemplos:
            80
            ( 10 != 3 ) ? "Maria" : "Alex" "Maria"*/

            //Demo
            /*  double preco = 34.5;
                double desconto;
                if (preco < 20.0) 
                {
                    desconto = preco * 0.1;
                }
                else 
                {
                    desconto = preco * 0.05;
                }
                double preco = 34.5;
                double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;*/
            Console.WriteLine("\n=====================================================================");

            Console.WriteLine("4) Funções interessantes para string.");

            string original = "abcde FGHIJ ABC abc DEFG    ";

            string s1 = original.ToUpper(); // para ficar tudo maiusculo;
            string s2 = original.ToLower(); // tudo minusculo
            string s3 = original.Trim(); // apaga os espaçoes em branco.

            int n1 = original.IndexOf("bc"); // procura a primeira posição do bc == 1
            int n2 = original.LastIndexOf("bc"); // procura a ultima posição == 17

            string s4 = original.Substring(3); // corta o string a partir da 3 posição pra tras, ou seja, cortou o a=0 b=1 c=2 (3 posiçoes)
            string s5 = original.Substring(3, 5); // corta a partir da terceira e pega 5 resultado ficaria = 'de FG';
            
            string s6 = original.Replace('a', 'x'); //substiu um caracter ou string Resultado = todo a minusculo troca por x
            string s7 = original.Replace("abc", "xy"); //Obs: para trocar string é necessario aspas duplas e pode ser qualquer tamanho de string.

            bool b1 = string.IsNullOrEmpty(original);// testa se a string é nula ou fazia no caso é = False.
            bool b2 = string.IsNullOrWhiteSpace(original); // a string não é nulo ou espaço em branco =  False.
            Console.WriteLine("\n=====================================================================");

            Console.WriteLine("\n5) DateTime.");
            Console.WriteLine("Representa um instante e é um tipo valor struct." +
                "armazena numero de ticks (100 nanosegundos)");

            DateTime d0 = DateTime.Now; //instancia o horario real da maquina atual do user
            //d1.Ticks = imprime um numero gigante desde do dia 1 de janeiro do ano 1.

            /*Instanciação
            • Construtores
            • DateTime(ano, mes, dia)
            • DateTime(ano, mes, dia, hora, minuto, segundo) [opcional: kind]
            • DateTime(ano, mes, dia, hora, minuto, segundo, milissegundo) [opcional: kind]
            • Builders
            • DateTime.Now
            • DateTime.UtcNow
            • DateTime.Today [time: 00:00:00]
            • DateTime.Parse(string)
            • DateTime.ParseExact(string, string)*/

            DateTime d1 = new DateTime(2018, 11, 25); //imprime esse dia as 00:00:00
            DateTime d2 = new DateTime(2018, 11, 25, 20, 45, 3); // imprime data mais horario = 20:45:03
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3, 500);

            DateTime d5 = DateTime.Today; // imprime data de hoje mas horario zerado.
            DateTime d6 = DateTime.UtcNow; //imprime o horario padrao de Greenwich +3mt

            DateTime d7 = DateTime.Parse("2000-08-15"); // imprime 15/08/2000 as 00hs
            DateTime d8 = DateTime.Parse("2000-08-15 13:05:58"); //imprime a data com horário
            DateTime d9 = DateTime.Parse("15/08/2000"); // imprime com padrão pt-br serve com horario tbm.
            DateTime d10 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture); //determina o formato da data
            DateTime d11 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine("\n=====================================================================");

            Console.WriteLine("\n6) TimeSpan.");
            Console.WriteLine("Representa uma duração e é um tipo valor struct." +
                "armazena duração de ticks (100 nanosegundos)");

            TimeSpan t0 = new TimeSpan(0, 1, 30);
            //t1.Ticks = imprime um numero gigante 900000000;

            TimeSpan t1 = new TimeSpan(); //passa o horario vaizo = 00hs
            TimeSpan t2 = new TimeSpan(900000000L); // resultado = 00:01:30
            TimeSpan t3 = new TimeSpan(2, 11, 21); // resultado = 02:11:21
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21); //passando dia e horario = 1.02:11:21
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321); //passando dia e horario e milisigundos = 1.02:11:21.32100000

            TimeSpan t6 = TimeSpan.FromDays(1.5); // result = 1.12:00:00 um dia e doze horas.
            TimeSpan t7 = TimeSpan.FromHours(1.5); // result = 01:30:00 um dia e doze horas.
                                                   //da pra fazer com .Minutes, .Seconds, .Miliseconds, .Ticks(900000000L)
            Console.WriteLine("\n=====================================================================");

            Console.WriteLine("07) Propriedades e Operações com DateTime");
           
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date); //desconsidera o horario
            Console.WriteLine("2) Day: " + d.Day); // so o dia = 15
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek); // quarta feira
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear); // dia 227 do ano
            Console.WriteLine("5) Hour: " + d.Hour); // 13
            Console.WriteLine("6) Kind: " + d.Kind); // não especificado
            Console.WriteLine("7) Millisecond: " + d.Millisecond); //275
            Console.WriteLine("8) Minute: " + d.Minute); //45
            Console.WriteLine("9) Month: " + d.Month); //8
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay); //é uma duração
            Console.WriteLine("13) Year: " + d.Year); //ano

            Console.WriteLine("\nFormatação1:");
            string st1 = d.ToLongDateString();// imprime por extenso = quarta feira, 15 de agosto de 2001
            string st2 = d.ToLongTimeString();// imprime o horario = 13:45:58
            string st3 = d.ToShortDateString();// imprime a data no formato resumido = 15/08/2001
            string st4 = d.ToShortTimeString();// imprime so hora e minuto = 13:45
            string st5 = d.ToString();// imprime formato padrao = 15/08/2001 13:45:58
            //abaixo com mascara de formatação.
            string st6 = d.ToString("yyyy-MM-dd HH:mm:ss");// 2001-08-15 13:45:58
            string st7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");//fff para imprimir os milisegundos.

            Console.WriteLine("\nAlgumas operações:");

            
            DateTime y1 = d.AddDays(7);// acrescenta 7 dias
            DateTime y2 = d.AddHours(2); // acrescenta duas hrs
            DateTime y3 = d.AddMilliseconds(12);// acrescenta 
            DateTime y4 = d.AddMinutes(3);// acrescenta minutos
            DateTime y5 = d.AddMonths(2); //acrescenta 2 meses
            DateTime y6 = d.AddSeconds(12); //acrescenta segundos
            DateTime y7 = d.AddTicks(9900000L);
            DateTime y8 = d.AddYears(2);// acrescenta anos
            TimeSpan t = d2.Subtract(d);
            Console.WriteLine("\n=====================================================================");

            Console.WriteLine("\n08) Propriedades e Operações com TimeSpan");
            TimeSpan tt = new TimeSpan(2, 3, 5, 7, 11);

            TimeSpan tt1 = TimeSpan.MaxValue;
            TimeSpan tt2 = TimeSpan.MinValue;
            TimeSpan tt3 = TimeSpan.Zero;
            Console.WriteLine(tt1);
            Console.WriteLine(tt2);
            Console.WriteLine(tt3);
            //Propriedades:
            Console.WriteLine(tt);//
            Console.WriteLine("Days: " + tt.Days);//2
            Console.WriteLine("Hours: " + tt.Hours);//3
            Console.WriteLine("Minutes: " + tt.Minutes);//5
            Console.WriteLine("Milliseconds: " + tt.Milliseconds);//11
            Console.WriteLine("Seconds: " + tt.Seconds);//7
            Console.WriteLine("Ticks: " + tt.Ticks);//
            Console.WriteLine("TotalDays: " + tt.TotalDays);//2,128...
            Console.WriteLine("TotalHours: " + tt.TotalHours);//52,085...
            Console.WriteLine("TotalMinutes: " + tt.TotalMinutes);//3065,1165...
            Console.WriteLine("TotalSeconds: " + tt.TotalSeconds);//183907,011...
            Console.WriteLine("TotalMilliseconds: " + tt.TotalMilliseconds);//183907011
            //Operações
            TimeSpan t01 = new TimeSpan(1, 30, 10);
            TimeSpan t02 = new TimeSpan(0, 10, 5);
            TimeSpan sum = t01.Add(t02);// 01:40:15
            TimeSpan dif = t01.Subtract(t02);//01:20:05
            TimeSpan mult = t02.Multiply(2.0);//00:20:10
            TimeSpan div = t02.Divide(2.0);//00:05:02.5000000
            Console.WriteLine("\n=====================================================================");

            Console.WriteLine("09 DateTimeKind e padrão ISO 8601:");
            Console.WriteLine("Tipo enumerado especial que define três valores possíveis para a\r\nlocalidade da data:\r\n• Local [ fuso horário do sistema. Exemplo: São Paulo = GMT -3 ]\r\n• Utc [ fuso horário GMT (Greenwich Mean Time) ]\r\n• Unspecified");
            /*Boa prática
            • Armazenar em formato UTC (texto: BD / Json / XML)
            • Instanciar e mostrar em formato Local
            Para converter um DateTime para Local ou Utc, você deve usar:
            • myDate.ToLocalTime()
            • myDate.ToUniversalTime()*/

            DateTime dd1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime dd2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime dd3 = new DateTime(2000, 8, 15, 13, 5, 58);
            Console.WriteLine("d1: " + dd1);// 15/08/2000 13:05:58
            Console.WriteLine("d1 Kind: " + dd1.Kind);// local
            Console.WriteLine("d1 to Local: " + dd1.ToLocalTime());// 15/08/2000 13:05:58
            Console.WriteLine("d1 to Utc: " + dd1.ToUniversalTime());// 15/08/2000 16:05:58
            Console.WriteLine();
            Console.WriteLine("d2: " + dd2);//15/08/2000 13:05:58
            Console.WriteLine("d2 Kind: " + dd2.Kind);//Utc
            Console.WriteLine("d2 to Local: " + dd2.ToLocalTime());// 15/08/2000 10:05:58
            Console.WriteLine("d2 to Utc: " + dd2.ToUniversalTime());// 15/08/2000 13:05:58
            Console.WriteLine();
            Console.WriteLine("d3: " + dd3);// 15/08/2000 13:05:58
            Console.WriteLine("d3 Kind: " + dd3.Kind);//unspecified
            Console.WriteLine("d3 to Local: " + dd3.ToLocalTime());// 15/08/2000 10:05:58
            Console.WriteLine("d3 to Utc: " + dd3.ToUniversalTime());// 15/08/2000 13:05:58

            /*Padrão ISO 8601
            • https://www.iso.org/iso-8601-date-and-time-format.html
            • https://en.wikipedia.org/wiki/ISO_8601
            • Formato:
            yyyy-MM-ddTHH:mm:ssZ
            * Z indica que a data/hora está em Utc*/

            DateTime d001 = DateTime.Parse("2000-08-15 13:05:58");//local
            DateTime d002 = DateTime.Parse("2000-08-15T13:05:58Z"); // cria local DateTime T e o Z. utc
            //Não adequado
            Console.WriteLine("d001: " + d001);// 15/08/2000 13:05:58
            Console.WriteLine("d001 Kind: " + d001.Kind);//unspecified
            Console.WriteLine("d001 to Local: " + d001.ToLocalTime());// 15/08/2000 10:05:58
            Console.WriteLine("d001 to Utc: " + d001.ToUniversalTime());// 15/08/2000 16:05:58
            Console.WriteLine();
            Console.WriteLine("d002: " + d002);// 15/08/2000 10:05:58
            Console.WriteLine("d002 Kind: " + d002.Kind);// local
            Console.WriteLine("d002 to Local: " + d002.ToLocalTime());// 15/08/2000 10:05:58
            Console.WriteLine("d002 to Utc: " + d002.ToUniversalTime());// 15/08/2000 13:05:58
            Console.WriteLine();
            Console.WriteLine(d002.ToString("yyyy-MM-ddTHH:mm:ssZ")); // cuidado!, pois pode dar problema = 2000-08-15T10:05:58Z
            Console.WriteLine(d002.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));// 2000-08-15T13:05:58Z
        }
    }
}
