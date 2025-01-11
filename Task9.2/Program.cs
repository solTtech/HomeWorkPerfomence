namespace Task9._2
{
    class Program
    {
        delegate double Operation(double x, double y);

        enum OperationType
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Метод для вибору операції
            Operation SelectOperation(OperationType opType)
            {
                Operation Add = (x, y) => x + y;
                Operation Subtract = (x, y) => x - y;
                Operation Multiply = (x, y) => x * y;
                Operation Divide = (x, y) =>
                {
                    if (y == 0)
                    {
                        Console.WriteLine("Помилка: ділення на нуль!");
                        return double.NaN;
                    }
                    return x / y;
                };

                return opType switch
                {
                    OperationType.Add => Add,
                    OperationType.Subtract => Subtract,
                    OperationType.Multiply => Multiply,
                    OperationType.Divide => Divide,
                    _ => throw new InvalidOperationException("Невідома операція.")
                };
            }

            Console.WriteLine("Програма для виконання арифметичних дій за допомогою делегата.");

            while (true)
            {
                Console.WriteLine("\nОберіть дію (Add, Subtract, Multiply, Divide) або введіть 'exit' для виходу:");
                string operationInput = Console.ReadLine()?.Trim().ToLower();

                if (operationInput == "exit")
                {
                    Console.WriteLine("Програма завершена.");
                    break;
                }

                if (!Enum.TryParse(operationInput, true, out OperationType operationType))
                {
                    Console.WriteLine("Помилка: введіть коректну операцію (Add, Subtract, Multiply, Divide).");
                    continue;
                }

                Console.WriteLine("Введіть перше число:");
                if (!double.TryParse(Console.ReadLine(), out double num1))
                {
                    Console.WriteLine("Помилка: введіть коректне число!");
                    continue;
                }

                Console.WriteLine("Введіть друге число:");
                if (!double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.WriteLine("Помилка: введіть коректне число!");
                    continue;
                }

                try
                {
                    Operation selectedOperation = SelectOperation(operationType);
                    double result = selectedOperation(num1, num2);
                    Console.WriteLine($"Результат: {result}");
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
