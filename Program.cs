namespace Projeto1
{
    class Program
    {
        static double x = 0;
        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair }

        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo");

            bool i = false;
            while (!i)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1_Soma\n2_Subtração\n3_Divisão\n4_Multiplicação\n5_Potência\n6_Raiz\n7_Sair");

                string RespostaMenu;
                int RespostaMenuInt;

                //Tratamento de erros de ususario
                while (true)
                {
                    RespostaMenu = Console.ReadLine();
                    while (string.IsNullOrEmpty(RespostaMenu))
                    {
                        if (string.IsNullOrEmpty(RespostaMenu))
                        {
                            Console.Clear();
                            Console.WriteLine("Por favor, escolha uma das opções entre 1 e 7");
                            Console.WriteLine("1_Soma\n2_Subtração\n3_Divisão\n4_Multiplicação\n5_Potência\n6_Raiz\n7_Sair");
                            RespostaMenu = Console.ReadLine();
                        }
                    }

                    int.TryParse(RespostaMenu, out RespostaMenuInt);
                    if (RespostaMenuInt > 0 && RespostaMenuInt < 8)
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Por favor, escolha uma das opções entre 1 e 7");
                        Console.WriteLine("1_Soma\n2_Subtração\n3_Divisão\n4_Multiplicação\n5_Potência\n6_Raiz\n7_Sair");

                    }
                }
                //Fim do tratamanto (MENU)

                Menu opcao = (Menu)RespostaMenuInt;
                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Sub();
                        break;
                    case Menu.Divisao:
                        Div();
                        break;
                    case Menu.Multiplicacao:
                        Mult();
                        break;
                    case Menu.Potencia:
                        Pot();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        i = !i;
                        Console.WriteLine("\nAté mais tarde");
                        break;
                }
            }

        }

        static void Soma()
        {
            Console.WriteLine("\nSoma\nDigiti o primeiro valor a ser somado:");
            double aSoma = TratamentoNumerico();
            Console.WriteLine("Digite o segundo valor a ser somado:");
            double bSoma = TratamentoNumerico();
            Console.Clear();
            double TotalSoma = aSoma + bSoma;
            Console.WriteLine("{0} + {1} = {2}\n", aSoma, bSoma, TotalSoma);
            Thread.Sleep(1500);
        }

        static void Sub()
        {
            Console.WriteLine("\nSubTração\nDigiti o primeiro valor para a subtrair:");
            double aSub = TratamentoNumerico();
            Console.WriteLine("Digite o segundo valor a ser subtração:");
            double bSub = TratamentoNumerico();
            Console.Clear();
            double TotalSub = aSub - bSub;
            Console.WriteLine("{0} - {1} = {2}\n", aSub, bSub, TotalSub);
            Thread.Sleep(1500);
        }

        static void Div()
        {
            Console.WriteLine("\nDivisão\nDigiti o primeiro valor que vai ser dividido:");
            double aDiv = TratamentoNumerico();
            Console.WriteLine("Digite por quanto ele deve ser dividido:");
            double bDiv = TratamentoNumerico();
            if (bDiv == 0)
            {
                Console.WriteLine("!!ERRO!!\n");
                return;
            }
            Console.Clear();
            double TotalDiv = aDiv / bDiv;
            Console.WriteLine("{0} / {1} = {2}\n", aDiv, bDiv, TotalDiv);
            Thread.Sleep(1500);
        }

        static void Mult()
        {
            Console.WriteLine("\nMultiplicação\nDigiti o primeiro valor a ser multiplicado:");
            double aMult = TratamentoNumerico();
            Console.WriteLine("Digite por quanto ele deve ser multiplicado:");
            double bMult = TratamentoNumerico();
            Console.Clear();
            double TotalMult = aMult / bMult;
            Console.WriteLine("{0} * {1} = {2}\n", aMult, bMult, TotalMult);
            Thread.Sleep(1500);
        }
        static void Pot()
        {
            Console.WriteLine("\nPotêncialização\nDigiti o valor da base:");
            double aPot = TratamentoNumerico();
            Console.WriteLine("Digite o valor do expoente:");
            double bPot = TratamentoNumerico();
            Console.Clear();
            double TotalPot = Math.Pow(aPot, bPot);
            Console.WriteLine("{0}^{1} = {2}\n", aPot, bPot, TotalPot);
            Thread.Sleep(1500);
        }

        static void Raiz()
        {
            Console.WriteLine("\nRaiz\nDigiti o valor do radicando da Raiz:");
            double aRaiz = TratamentoNumerico();
            Console.WriteLine("Digite o valor do índice da Raiz:");
            double bRaiz = TratamentoNumerico();
            Console.Clear();
            double TotalRaiz = Math.Pow(aRaiz, (1 / bRaiz));
            Console.WriteLine("A Raiz de {0} sobre o índice de {1} = {2}\n", aRaiz, bRaiz, TotalRaiz);
            Thread.Sleep(1500);
        }

        //Tratamentos de Entrada de Usuario Númerico 
        static double TratamentoNumerico()
        {
            do
            {
                double usuarioEntrada = Tryparse(Console.ReadLine());
                x = usuarioEntrada;
            } while (x == -844659581);

            return x;
        }
        static double Tryparse(string Readline)
        {
            double A = -844659581;
            if (double.TryParse(Readline, out A))
            {
                return A;
            }
            Console.WriteLine("O valor inserido deve ser um número!");
            return -844659581;
        }
    }
}