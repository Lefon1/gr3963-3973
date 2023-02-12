Console.Clear();
                Console.Write("Введите первое число: ");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число: ");
                int number2 = Convert.ToInt32(Console.ReadLine());

                int number = Math.Abs(number1);

                for (int i = 0; i < number; i++)
                {
                    Console.Write($"Остаток от деления {i} на {number2} = {i% number2}\n");
                }