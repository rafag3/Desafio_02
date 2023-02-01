using System;

namespace Desafio_02
{
    class Program
    {
        static void Main(string[] args)
        {

            //Imprime na tela
            Console.WriteLine("UBUNTU 002 - STARTS...");

            string nome1 = "Ubuntu1 Silva";
            int idade1 = 33;
            double peso1 = 88.50;
            double altura1 = 1.65;
            bool EhDev1 = true;

            string nome2 = "Ubuntu2 Santos";
            int idade2 = 26;
            double peso2 = 84.50;
            double altura2 = 2.10;
            bool EhDev2 = true;

            string nome3 = "Ubuntu3 Silva";
            int idade3 = 85;
            double peso3 = 66.50;
            double altura3 = 1.40;
            bool EhDev3 = false;


            //T1 - Somar a idade de todos Ubuntus

            int todosIdade = ( idade1 + idade3 + idade3);
            Console.WriteLine("Idade de todos ubuntos: " + todosIdade);


            //T2 - Agrupar os nomes de todos Ubuntus
            string grupoName = (nome1 + " - " + nome2 + " - " + nome3);
            Console.WriteLine("Nomes de todos Ubuntus: " + grupoName);


            //T3 - Calcular Média dos IMC de todos Ubuntus
            Console.WriteLine(nome1, nome2, nome3);
            Console.WriteLine( nome1 + " IMC: " + peso1 / (altura1 * altura1));
            Console.WriteLine( nome2 + " IMC: " + peso2 / (altura2 * altura2));
            Console.WriteLine( nome3 + " IMC: " + peso3 / (altura3 * altura3));

            //T4 - Contar quantos Ubuntus sao Devs

            int contador = 0;
            if (EhDev1 == true)
            {
                Console.WriteLine(nome1 + ": É DEV");
                contador = contador + 1;
            }
            if (EhDev2 == true)
            {
                Console.WriteLine(nome2 + ": É DEV");
                contador = contador + 1;
            }

            if (EhDev3 == false)
            {
                Console.WriteLine(nome3 + ": NÃO É DEV");
                contador = contador + 0;
            }
            Console.WriteLine(" Total de DEVS: " + contador);



            //T5 - Exibir somente Ubuntu com nome Silva
            Console.WriteLine("Com sobrenomes SILVA: " + nome1 + " - " + nome3);


            //Imprime na tela
            Console.WriteLine("UBUNTU 002 - ENDS...");

         
        }


    }
}
