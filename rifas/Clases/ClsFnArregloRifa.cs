using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace rifas.Clases
{
    internal class ClsFnArregloRifa
    {
        public int aleatorio(int n1, int n2)
        {
            {
                var r = new Random();

                for (int i = 0; i < 10; i++)
                {
                    Console.Write("{0} ", r.Next(1, 11));
                }

                return r.Next(n1 -1, n2 -1);

            }
        }

        public void Rifa(string[] nombresrifa, int premios)
            {
                for (int i = 0; i < premios; i++)
                {
                    int tombola = aleatorio(0, nombresrifa.Length);
                    Console.Write($"Rifa numero {i} \t Tombola numero = {tombola}\n");

                    Console.WriteLine($"\tEl ganador de esta rifa es {nombresrifa[tombola]}");
                }

            }
        }
    }
