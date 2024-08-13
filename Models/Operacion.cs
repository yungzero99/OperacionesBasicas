using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesBasicas.Models
{
    internal class Operacion
    {
        public double _numero1 { get; set; }
        public double _numero2 { get; set; }
        public double Suma { get; set; }
        public double Resta { get; set; }
        public double Multiplicacion { get; set; }
        public double Division { get; set; }
        public int _count { get; set; }

        public void Decrement()
        {
            _count--;
        }
        public void Increment()
        {
            _count++;
        }

        public void Sumar()
        {
            Suma = _numero1 + _numero2;
        }
        public void Restar()
        {
            Resta = _numero1 - _numero2;
        }
        public void Multiplicar()
        {
            Multiplicacion = _numero1 * _numero2;
        }
        public void Dividir()
        {
            Division = _numero1 / _numero2;
        }

    }

}
