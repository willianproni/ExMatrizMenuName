using System;

namespace MatrizInsertName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] matriz = new string[3, 3];
            int ops;
            bool check = false;

            void Menu()
            {
                Console.WriteLine("----------Matriz Nomes----------" +
                                  "\n[1] - Inserir nomes das Matriz" +
                                  "\n[2] - Imprimir nomes" +
                                  "\n[3] - Imprmir Linha Determinada" +
                                  "\n[4] - Imprimir Coluna Determinada" +
                                  "\n[5] - Procurar Nome" +
                                  "\n[6] - Ordenar Nomes por Linha" +
                                  "\n[7] -  Fechar" +
                                  "\n--------------------------------");
                Console.Write("Opção:");
                ops = int.Parse(Console.ReadLine());
            }

            void Inserir()
            {
                Console.Clear();
                Console.WriteLine("-------------INSERIR MATRIZES------------------\n");
                for (int l = 0; l < matriz.GetLength(0); l++)
                {
                    for (int c = 0; c < matriz.GetLength(1); c++)
                    {
                        Console.Write($"Insira o Nome da posição [{l}][{c}]: ");
                        matriz[l, c] = Console.ReadLine();
                    }
                }
                Console.WriteLine("\t\nTodas as matrizes adicionadas!!");
                Console.ReadKey();
                Console.Clear();
            }

            void Print()
            {
                check = true;
                Console.Clear();
                if (check == false)
                {
                    Console.WriteLine("Nenhuma Matriz inserida!!");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("---------Mostrando Resultado----------------");
                    for (int l = 0; l < matriz.GetLength(0); l++)
                    {
                        for (int c = 0; c < matriz.GetLength(1); c++)
                        {
                            Console.Write($"\tMatriz[{l}][{c}] = {matriz[l, c]}");
                        }
                        Console.WriteLine();
                    }
                    Console.ReadKey();
                    Console.Clear();
                }

            }

            void PrintLinha()
            {
                Console.Clear();
                if (check == false)
                {
                    Console.Clear();
                    Console.WriteLine("Nenhuma Matriz inserida!!");
                   
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"Digite a Linha que deseja imprimir 0 a 2: ");
                    int linha = int.Parse(Console.ReadLine());
                    for (int l = linha; l <= linha; l++)
                    {
                        for (int c = 0; c < matriz.GetLength(1); c++)
                        { 
                            Console.WriteLine(matriz[l, c]);
                        }
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            void PrintColuna()
            {
                Console.Clear();
                if (check == false)
                {
                    Console.WriteLine("Nenhuma Matriz inserida!!");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {

                    Console.WriteLine("Digite a Coluna que deseja imprimir: ");
                    int coluna = int.Parse(Console.ReadLine());

                    for (int l = 0; l < matriz.GetLength(0); l++)
                    {
                        for (int c = coluna; c <= coluna; c++)
                        {
                            Console.WriteLine(matriz[l, c]);
                        }
                    }

                    Console.ReadKey();
                    Console.Clear();
                }
            }

            void Seach()
            {
                bool check2 = false;
                Console.Clear();
                if (check == false)
                {
                    Console.WriteLine("Nenhuma Matriz inserida!!");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Busque o Nome:");
                    string nome = Console.ReadLine();

                    for (int l = 0; l < matriz.GetLength(0); l++)
                    {
                        for (int c = 0; c < matriz.GetLength(1); c++)
                        {
                            if (nome == matriz[l, c])
                            {
                                check2 = true;
                                Console.WriteLine($"{nome} na matriz[{l}][{c}]");
                            }
                        }
                    }
                }
                if (check2 == false)
                {
                    Console.Clear();
                    Console.WriteLine("Nenhum Contato encontrado");

                }
                Console.ReadKey();
                Console.Clear();
            }

            void Ordenar()
            {
                Console.Clear();
                if (check == false)
                {
                    Console.WriteLine("Nenhuma Matriz inserida!!");
                }
                else
                {
                    Console.WriteLine("Linha que deseja ordenar 0 a 2:");
                    int linha = int.Parse(Console.ReadLine());
                    for (int l = linha; l <= linha; l++)
                    {
                        for (int c = 0; c < matriz.GetLength(1); c++)
                        {
                            for (int a = 0; a < matriz.GetLength(1); a++)
                            {
                                if (matriz[l, a].CompareTo(matriz[l, c]) == 1)
                                {
                                    string suport = matriz[l, a];
                                    matriz[l, a] = matriz[l, c];
                                    matriz[l, c] = suport;
                                }
                            }

                        }
                    }
                }
                Console.Clear();
            }

            do
            {
                Menu();

                switch (ops)
                {
                    case 1:
                        Inserir();
                        break;
                    case 2:
                        Print();
                        break;
                    case 3:
                        PrintLinha();
                        break;
                    case 4:
                        PrintColuna();
                        break;
                    case 5:
                        Seach();
                        break;
                    case 6:
                        Ordenar();
                        break;
                    case 7:
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Console.WriteLine();
            } while (ops != 7);
        }
    }
}
