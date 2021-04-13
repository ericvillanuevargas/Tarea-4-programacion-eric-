﻿using System;
using System.Collections.Generic;
using System.Text;

namespace tarea_4_eric
{
    class Cimplementacion2:Ibridge
    {
        public void MostrarTotales(Dictionary<string, double> pProductos)
        {
            double total = 0;
            double totalm = 0;
            double totalc = 0;
            double totald = 0;
            int cantidad = 0;

            foreach (KeyValuePair<string, double> p in pProductos)
            {
                total += p.Value;

                if (p.Key[0] == 'C')
                    totalc += p.Value;
                if (p.Key[0] == 'M')
                    totalm += p.Value;
                if (p.Key[0] == 'D')
                    totald += p.Value;

                cantidad++;


            }

            Console.WriteLine("El total de comida es ${0}", totalc);
            Console.WriteLine("El total de medicamentos  es ${0}", totalm);
            Console.WriteLine("El total de deportes es ${0}", totald);

            Console.WriteLine("El total de  {0} productos es ${1}", cantidad, total);

        }

        public void ListarProductos(Dictionary<string, double> pProductos)
        {
            foreach (KeyValuePair<string, double> p in pProductos)
            {
                if (p.Key[0] == 'C')
                    Console.ForegroundColor = ConsoleColor.Yellow;

                if (p.Key[0] == 'M')
                    Console.ForegroundColor = ConsoleColor.Green;

                if (p.Key[0] == 'D')
                    Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("{0}- {1}", p.Key, p.Value);

            }

        }


    }
}