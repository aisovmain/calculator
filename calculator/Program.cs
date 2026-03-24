namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор на C#");
            Console.WriteLine("Доступные операции: +, -, *, /");
            Console.WriteLine("Для выхода введите 'exit'");

            while (true)
            {
                try
                {
                    Console.Write("\nВведите первое число: ");
                    string? input1 = Console.ReadLine();
                    if (input1?.ToLower() == "exit") break;

                    if (!double.TryParse(input1, out double num1))
                    {
                        Console.WriteLine("Ошибка: введите корректное число!");
                        continue;
                    }

                    Console.Write("Введите операцию (+, -, *, /): ");
                    string? operation = Console.ReadLine();

                    Console.Write("Введите второе число: ");
                    string? input2 = Console.ReadLine();
                    if (input2?.ToLower() == "exit") break;

                    if (!double.TryParse(input2, out double num2))
                    {
                        Console.WriteLine("Ошибка: введите корректное число!");
                        continue;
                    }

                    double result = 0;
                    bool isValidOperation = true;

                    switch (operation)
                    {
                        case "+":
                            result = num1 + num2;
                            break;
                        case "-":
                            result = num1 - num2;
                            break;
                        case "*":
                            result = num1 * num2;
                            break;
                        case "/":
                            if (num2 == 0)
                            {
                                Console.WriteLine("Ошибка: деление на ноль!");
                                isValidOperation = false;
                            }
                            else
                            {
                                result = num1 / num2;
                            }
                            break;
                        default:
                            Console.WriteLine("Ошибка: неизвестная операция!");
                            isValidOperation = false;
                            break;
                    }

                    if (isValidOperation)
                    {
                        Console.WriteLine($"Результат: {num1} {operation} {num2} = {result}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Произошла ошибка: {ex.Message}");
                }
            }

            Console.WriteLine("До свидания!");
        }
    }
}
