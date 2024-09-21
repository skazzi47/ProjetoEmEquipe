using System;
using System.IO;

class Program
{
    public static void Main(string[] args)
    {
        // modelo básico de cadastro local de informações básicas do usuário com cáuculo de IMC (nome, data de nascimento, peso e altura)
        // Modelo simples e rápido sem foco em detalhes de implementação ou contorno de erro de input do usuário
        using (StreamWriter escrever = new StreamWriter("PerfisIMC.txt"))
        {
        repe:
            Console.Write("Quantos perfis deseja cadastrar? ");
            if (!int.TryParse(Console.ReadLine(), out int vezes) && vezes > 0)
            {
                Console.WriteLine("Digite um número inteiro válido!");
                goto repe;
            }
            int cont;

            string[] nomes = new string[vezes];
            string[] datas = new string[vezes];
            float[] pesos = new float[vezes];
            float[] alturas = new float[vezes];

            for (cont = 0; cont < vezes; cont++)
            {
                Console.Clear();
                Console.WriteLine("Próximo perfil : ");
            repetir:
                Console.Write("Insira o seu nome : ");

                string n = Console.ReadLine();

                Console.Write($"Confirma o nome {n}? (S para sim N para não) > ");

                char confirma = char.Parse(Console.ReadLine().ToLower());

                if (confirma != 's')
                {
                    goto repetir;
                }

                nomes[cont] = n;

                Console.Write("Insira a sua data de nascimento : ");
                string d = Console.ReadLine();

                datas[cont] = d;

            repetir2:
                Console.Write("Insira o seu peso : ");
                if (!float.TryParse(Console.ReadLine(), out float p))
                {
                    Console.WriteLine("Insira um valor válido");
                    goto repetir2;
                }

                pesos[cont] = p;

            repetir3:
                Console.Write("Insira a sua altura : ");
                if (!float.TryParse(Console.ReadLine(), out float a))
                {
                    Console.WriteLine("Insira um valor válido");
                    goto repetir3;
                }

                alturas[cont] = a;

            }

            Console.WriteLine("Deseja ver os perfis cadastrados e seus IMC? (S para sim N para não) > ");
            char resp = char.Parse(Console.ReadLine().ToLower());
            if (resp == 's')
            {
                Console.Clear();
                Console.WriteLine("Estão cadastrados no sistema os seguintes perfis :");
                for (int i = 0; i < vezes; i++)
                {
                    Console.WriteLine($"Nome: {nomes[i]} | Data de nascimento: {datas[i]} | Peso: {pesos[i]} | Altura {alturas[i]} | IMC: {pesos[i] / (alturas[i] * alturas[i]):F2}");
                    escrever.WriteLine($"Nome: {nomes[i]} | Data de nascimento: {datas[i]} | Peso: {pesos[i]} | Altura {alturas[i]} | IMC: {pesos[i] / (alturas[i] * alturas[i]):F2}");
                }
            }
        }
    }
}
