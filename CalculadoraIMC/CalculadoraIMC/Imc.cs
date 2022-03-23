﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraIMC
{
    public class Imc
    {
        private float peso;
        private float altura;

        public float Altura
        {
            get => altura;
            set => altura = value;
        }

        public float Peso
        {
            get => peso;
            set => peso = value;
        }

        public float calculaImc()
        {
            float imc = peso / (altura * altura);
            return imc;

        }

        public string classificaIMC(float imc)
        {
            string classificacao = "";

            if (imc < 16)
            {
                classificacao = "Magreza grau III";
            }
            else if (imc >= 16 && imc <= 16.9)
            {
                classificacao = "Magreza grau II";
            }
            else if (imc >= 17 && imc < 18.5)
            {
                classificacao = "Magreza grau I";
            }
            else if (imc >= 18.5 && imc < 25)
            {
                classificacao = "Adequado";
            }
            else if (imc >= 25 && imc < 30)
            {
                classificacao = "Sobrepeso  ";
            }
            else if (imc >= 30 && imc < 35)
            {
                classificacao = "Obesidade grau I";
            }
            else if (imc >= 35 && imc <= 40)
            {
                classificacao = "Obesidade grau II";
            }
            else
            {
                classificacao = "Obesidade grau III";
            }

            return classificacao;
        }


    }
}
