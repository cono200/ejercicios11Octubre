using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios11Octubre
{
    internal class Class1
    {
        public void matrizbOOL()
        {
            // bool[,] verdadfalso = new bool[3,2];

            bool[,] verdadfalso = { { true, false }, { false, false }, { true, true } };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(verdadfalso[i, j]);
                }
            }
        }


        public void SumarArray()
        {
            int[,] numero1 = { { 1, 2 }, { 3, 4 }, { 4, 5 } };
            int[,] numero2 = { { 2, 3 }, { 5, 6 }, { 9, 11 } };

            int[,] resultado = new int[3, 2];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {

                    resultado[i, j] = numero1[i, j] + numero2[i, j];


                    Console.WriteLine(resultado[i, j]);

                }

            }
        }

        public void MultiplicarArray()
        {
            int[,] numero1 = { { 1, 2 }, { 3, 4 }, { 4, 5 } };
            int[,] numero2 = { { 2, 3 }, { 5, 6 }, { 9, 11 } };

            int[,] resultado = new int[3, 2];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {

                    resultado[i, j] = numero1[i, j] * numero2[i, j];


                    Console.WriteLine(resultado[i, j]);

                }

            }
        }
        }
}
