using System;
using System.Globalization;

namespace ExerciciosEstruturaCondicional {
    class Program {
        static void Main(string[] args) {

            //Exercicio 01 - Fazer um programa para ler um número inteiro e depois dizer se este número é negativo ou não.

            Console.WriteLine("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if (num >= 0) {
                Console.WriteLine("Não negativo!");
            } else {
                Console.WriteLine("Negativo!");
            }




        }
    }
}