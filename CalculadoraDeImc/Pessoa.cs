using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeImc
{
    public class Pessoa
    {
        public string name { get; set; }
        public int age { get; set; }
        public double weight { get; set; }
        public double height { get; set; }


        public Pessoa()
        {
        }
        public Pessoa(string name, int age, double weight, double height)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
            this.height = height;
        }
        public double IMC()
        {
            return weight / (height * height);
        }

        public string IMCtxt()
        {
            double imc = IMC();
            if (imc < 0.0018)
                return "Abaixo do peso";
            else if (imc < 0.0025)
                return "Peso normal";
            else if (imc < 0.0030)
                return "Sobrepeso";
            else
                return "Obesidade";
        }


    }
}
