using System;
using System.Globalization;

namespace ExerciciosEstruturaCondicional {
    class Program {
        static void Main(string[] args) {

            /* Exercicio 01 - Fazer um programa para ler um número inteiro e depois dizer se este número é negativo ou não.

            Console.WriteLine("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if (num >= 0) {
                Console.WriteLine("Não negativo!");
            } else {
                Console.WriteLine("Negativo!");
            }

            */

            /* Exercício 02 - Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.

            Console.WriteLine("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0) {
                Console.WriteLine("Número par!");
            }
            else {
                Console.WriteLine("Número ímpar!");
            }

            */

            /* Exercício 03 - Leia 2 valores inteiros (A e B). Após isso, o programa deve mostrar uma mensagem "São múltiplos" ou "Não são múltiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem ser digitados em ordem crescente ou decrescente.

            Console.WriteLine("Digite dois números inteiros (na mesma linha): ");
            string[] numeros = Console.ReadLine().Split(' ');
            int num1 = int.Parse(numeros[0]);
            int num2 = int.Parse(numeros[1]);

            if (num1 % num2 == 0 || num2 % num1 == 0) {
                Console.WriteLine("São múltiplos!");
            }
            else {
                Console.WriteLine("Não são múltiplos!");
            }

            */







        }
    }
}