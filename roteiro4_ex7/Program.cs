using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roteiro4_ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, i, fx1=0, fx2=0, fx3=0, fx4=0, fx5=0;

            for (i = 0; i < 8; i++)
            {
                Console.WriteLine("Digite a idade: ");
                idade = int.Parse(Console.ReadLine());
                if (idade < 0)
                {
                    Console.WriteLine("A idade digitada é inválida.");
                    i--;
                }
                else
                {
                    if (idade > 60)
                    {
                        fx5++;

                    }
                    else if (idade > 45)
                    {
                        fx4++;
                    }
                    else if(idade > 30)
                    {
                        fx3++;
                    }
                    else if (idade > 15)
                    {
                        fx2++;
                    }
                    else if(idade >= 0)
                    {
                        fx1++;
                    }




                }
            }
            Console.WriteLine("A 1ª Faixa Etária possui: " + fx1 + " pessoas.\n");
            Console.WriteLine("A 2ª Faixa Etária possui: " + fx2 + " pessoas.\n");
            Console.WriteLine("A 3ª Faixa Etária possui: " + fx3 + " pessoas.\n");
            Console.WriteLine("A 4ª Faixa Etária possui: " + fx4 + " pessoas.\n");
            Console.WriteLine("A 5ª Faixa Etária possui: " + fx5 + " pessoas.\n");
            Console.WriteLine("A porcentagem de pessoas na 1ª faixa etária é: "+(fx1*100)/i+"%.");
            Console.WriteLine("A porcentagem de pessoas na 5ª faixa etária é: " + (fx5 * 100) / i + "%.");
            Console.ReadKey();
        }
    }
}
