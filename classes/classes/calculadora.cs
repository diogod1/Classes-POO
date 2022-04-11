using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    internal class calculadora
    {
        public float Soma(int n1, int n2)
        {
            return n1+n2;
        }

        public float Multiplicaçao(int n1, int n2)
        {
            return n1 * n2;
        }

        public float subtraçao(int n1, int n2)
        {
            return (n1 - n2);
        }

        public float divisao(int n1, int n2)
        {
            return n1 / n2;
        }
    }
}
