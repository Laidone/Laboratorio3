/*
 Nome: Laidone Mendes de Carvalho
 Laboratório 3 da trilha .NET
 */

using System;


namespace Laboratorio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Exemplo um feito com foreach
            
            DateTime[] dt = new DateTime[2]; 
            int iDate; 
            dt[0] = new DateTime(2002, 5, 1); 
            dt[1] = new DateTime(2002, 6, 1); 
            for (iDate = 0; iDate < 2; iDate++) 
            { 
                Console.WriteLine("Indice = " + iDate + " & Data = " + dt[iDate].ToShortDateString()); 
            }
            
            /*
                Exemplo dois feito com foreach
               
            string[] str = new string[3];
            str[0] = "Um";
            str[1] = "Dois";
            str[2] = "Tres";
            int cont = 0;
            foreach (string iStr in str)
            {
                Console.WriteLine("Indice = " + cont + " & Valor = " + iStr);
                cont++;
                //Console.WriteLine("Indice = " + iStr + " & Valor = " + str[iStr]);
            }

             */

            
             
           /*Exemplo 3 feito com foreach
        
            DateTime[] dt = new DateTime[2];
            dt[0] = new DateTime(2002, 5, 1);
            dt[1] = new DateTime(2002, 6, 1);
            int cont = 0;
            foreach (DateTime dt2 in dt)
            {
                Console.WriteLine("Indice = " + cont + " & Data = " + dt2.ToShortDateString());
                cont++;
            } 
            
            */

            /*
             
            Questão 1
             
              int[] array_One = new int[100];
              int[] array_Two = new int[100];
              for (int i = 0; i < array_One.Length ; ++i)
                {
                    array_One[i] = i;
                }
                for(int i = 0; i < array_Two.Length ; ++i)
                {
                array_Two[i] = array_One[i];
                Console.Write(array_Two[i] + " ")
             
             */



            /*
            
            Questão 2 versão array jagged

            int[][] matriz_Two = new int[5][];
            matriz_Two[0] = new int[] { 0, 1, 2, 3, 4 };
            matriz_Two[1] = new int[] { 0, 1, 2, 3, 4 };
            matriz_Two[2] = new int[] { 0, 1, 2, 3, 4 };
            matriz_Two[3] = new int[] { 0, 1, 2, 3, 4 };
            matriz_Two[4] = new int[] { 0, 1, 2, 3, 4 };
            int soma = 0;
            for (int i = 0; i < 5; i++)
            {
                soma = 0;
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matriz_Two[i][j] + " ");
                }
                Console.WriteLine("");
            }
            for(int i = 0;i < 5; i++)
            {
                soma = 0;
                for(int j = 0; j < 5; ++j)
                {
                    soma = soma + matriz_Two[j][i];
                }
                Console.WriteLine("Valor da soma da coluna " + i + " é " + soma);
            
            }

            */

            /*
            
            Questão 2 versão array multidimensional
             
            int[,] matriz_One = new int[5, 5];
            int soma = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz_One[i, j] = j;
                    Console.Write(matriz_One[i, j] + " ");
                }
                Console.WriteLine("");
            }
            for (int i = 0; i < 5; i++)
            {
                soma = 0;
                for (int j = 0; j < 5; j++)
                {
                    soma = soma + matriz_One[j, i];
                }
                Console.WriteLine("Valor da soma da coluna " + i + " é " + soma);
            }*/

        }
    }
}