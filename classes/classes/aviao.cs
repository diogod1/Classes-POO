using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    internal class aviao
    {
        //atributos
        private string _modelo;
        private float _velocidade;
        private float _altitude;
        private string _marca;

        //metodos

        public static void reduzir()
        {
            Console.WriteLine("reduzir");
        }

        public static void descer()
        {
            Console.WriteLine("descer");
        }

        public static void acelerar()
        {
            Console.WriteLine("Acelerar");
        }

        public string subir()
        {
            return "subir";
        }
    }
}
