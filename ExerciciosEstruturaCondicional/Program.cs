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

            /* Exercício 03 - Leia 2 valores inteiros (A e B). Após isso, o programa deve mostrar uma mensagem "São múltiplos" 
             * ou "Não são múltiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem ser digitados 
             * em ordem crescente ou decrescente.

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

            /* Exercício 04 - Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o 
             * mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.

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
            
            */

            /* Exercício 05 - Com base nos dados abaixo, escreva um programa que leia o código de um item e a quantidade do mesmo. 
             * A seguir, calcule e mostre o valor da conta a pagar.
                codigo (1) - item (cachorro quente) - preço (R$4,00)
                codigo (2) - item (       x-salada) - preço (R$4,50)
                codigo (3) - item (        x-bacon) - preço (R$5,00)
                codigo (4) - item (torrada simples) - preço (R$2.00)
                codigo (5) - item (   refrigerante) - preço (R$1,50)
            

            Console.WriteLine("Digite o código do produto e a quantidade comprada (na mesma linha): ");
            string[] pedido = Console.ReadLine().Split(' ');
            int codigo = int.Parse(pedido[0]);
            int quantidade = int.Parse(pedido[1]);

            double total;

            if (codigo == 1) {
                total = quantidade * 4.0;
            }
            else if (codigo == 2) {
                total = quantidade * 4.5;
            }
            else if (codigo == 3) {
                total = quantidade * 5.0;
            }
            else if (codigo == 4) {
                total = quantidade * 2.0;
            }
            else {
                total = quantidade * 1.5;
            }


            Console.WriteLine("TOTAL A PAGAR: R$" + total.ToString("F2"), CultureInfo.InvariantCulture);

            */

            /* Exercício 06 - Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos 
             * seguintes intervalos ([0,25], [25,50], [50,75], [75,100]) este valor se encontra. 
             * Obviamente se o valor não estiver em nenhum desses intervalos, deverá ser impressa a mensagem "Fora de intervalo".


            Console.WriteLine("Digite um valor: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            if (valor < 0 || valor > 100) {
                Console.WriteLine("Fora de intervalo.");
            }
            else if (valor <= 25) {
                Console.WriteLine("Intervalo [0,25].");
            }
            else if (valor <= 50) {
                Console.WriteLine("Intervalo [25,50].");
            }
            else if (valor <= 75) {
                Console.WriteLine("Intervalo [50,75].");
            }
            else {
                Console.WriteLine("Intervalo [75,100].");
            }

            */

            /* Exercício 07 - Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um 
             * plano. A seguir, determine o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na 
             * origem (x = y = 0). Se o ponto estiver na origim, escreva a mensagem "Origem". 
             * Se o ponto estiver sobre um dos eixos escreva "Eixo X" ou "Eixo Y", conforme for a situação. 
             * (Quadrantes de Q1 a Q4 seguindo ordem anti-horária).
             * 
             * 
            Console.WriteLine("Digite dois valores (na mesma linha: )");
            string[] valores = Console.ReadLine().Split(' ');
            double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            Console.WriteLine();

            if (x > 0 && y > 0) {
                Console.WriteLine("Q1.");
            }
            else if (x < 0 && y > 0) {
                Console.WriteLine("Q2.");
            }
            else if (x < 0 && y < 0) {
                Console.WriteLine("Q3.");
            }
            else if (x > 0 && y < 0) {
                Console.WriteLine("Q4.");
            }
            else if (x == 0 && y == 0) {
                Console.WriteLine("Origem.");
            }
            else if (x == 0 && y > 0 || y < 0) {
                Console.WriteLine("Eixo X.");
            }
            else {
                Console.WriteLine("Eixo Y.");
            }

            */

            /* Exercício 08 - Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos,
             * pois sabem que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da 
             * população, sem qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.
             * 
             * Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa em Lisarb. Em seguida, calcule e
             * mostre o valor que esta pessoa deve pagar de Imposto de Rendam, seguindo os dados abaixo:
             * 
             * Renda (de R$0000.00 até R$2000.00) - IR (Isento)
             * Renda (de R$2000.01 até R$3000.00) - IR (    8%)
             * Renda (de R$3000.01 até R$4500.00) - IR (   18%)
             * Renda (          acima de 4500.00) - IR (   28%)
             * 
             * Lembre que, se o salário for R$3002.00, a taxa que incide é de 8% apenas sobre R$1000.00, pois a faixa de
             * salário que fica de R$0.00 até R$2000.00 é isenta de Imposto de Renda.
             * 
             * */

            Console.WriteLine("Digite o salário: ");
            double salario = double.Parse(Console.ReadLine());






        }
    }
}