namespace calculator
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.WriteLine("-------------Dev Calculator-------------");
            showOptions();

            short option = short.Parse(Console.ReadLine());
            while (option != 0)
            {
                selectOption(option);
                showOptions();
                option = short.Parse(Console.ReadLine());
            }
        }

        static void showOptions()
        {
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("0 - Sair");
        }
        static void selectOption(short option)
        {
            switch (option)
            {
                case 1: operation("soma"); break;
                case 2: operation("subtração"); break;
                case 3: operation("multiplicação"); break;
                case 4: operation("divisão"); break;
                default: Console.WriteLine("Valor inválido!"); break;
            }
            Console.WriteLine("-------------");
        }
        static void operation(string operation)
        {
            Console.WriteLine("Primeiro valor :");
            double num1 = double.Parse(Console.ReadLine().Replace(".", ","));

            Console.WriteLine("Segundo valor :");
            double num2 = double.Parse(Console.ReadLine().Replace(".", ","));

            if (operation == "soma")
                Console.WriteLine($"O resultado da soma é {num1 + num2}");
            else if (operation == "subtração")
                Console.WriteLine($"O resultado da subtração é {num1 - num2}");
            else if (operation == "multiplicação")
                Console.WriteLine($"O resultado da multiplicação é {num1 * num2}");
            else if (operation == "divisão")
                Console.WriteLine($"O resultado da divisão é {num1 / num2}");
        }
    }
}