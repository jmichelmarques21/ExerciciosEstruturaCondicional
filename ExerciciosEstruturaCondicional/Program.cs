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

            // Exercício 04 - Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.

            Console.WriteLine("Digite o horário de início e o de fim do jogo (na mesma linha): ");
            string[] horarios = Console.ReadLine().Split(' ');
            int inicio = int.Parse(horarios[0]);
            int fim = int.Parse(horarios[1]);

            if (fim < inicio) {
                int duracao = fim + 24 - inicio;
                Console.WriteLine("O jogo durou {0} hora(s).", duracao);
            }
            else if (fim > inicio) {
                int duracao = fim - inicio;
                Console.WriteLine("O jogo durou {0} hora(s).", duracao);
            }
            else {
                Console.WriteLine("O jogo durou 24 horas.");
            }
            




        }
    }
}