using System;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Linq;


namespace Project
{
    class Practice1
    {
        //! Основные задачи 1-4
        public static void main_task1()
        {
            Console.WriteLine("\nЗадача №1:");
            double x = 1.82, y = 18, s = 0, w = 0;
            double num1 = Math.Pow(x, y / x);
            double num2 = Math.Pow(y / x, 0.5);
            s = Math.Abs(num1 - num2);
            Console.WriteLine($"s = {s}");
            w = (y - x) * (y / (1 + Math.Pow(y - x, 2)));
            Console.WriteLine($"w = {w}");
        }
        public static void main_task2()
        {
            Console.WriteLine("\nЗадача №2:");
            double x = 0.33, y = 0.02, s = 0, w = 0;
            s = 1 + x + (Math.Pow(x, 2) / 2) + (Math.Pow(x, 3) / 3) + (Math.Pow(x, 4) / 4);
            Console.WriteLine($"s = {s}");
            w = x * (Math.Sin(x) + Math.Cos(y));
            Console.WriteLine($"w = {w}");
        }
        public static void main_task3()
        {
            Console.WriteLine("\nЗадача №3. Введите значение t: ");
            double a = -0.5, b = 1.7, s = 0, w = 0; // x = 0.44
            double t = Convert.ToDouble(Console.ReadLine());
            s = Math.Pow(Math.E, -b * t) * Math.Sin(a * t + b) - Math.Pow(Math.Abs(b * t + a), 0.5);
            Console.WriteLine($"s = {s}");
            w = b * Math.Sin(a * Math.Pow(t, 2) * Math.Cos(a * t)) - 1;
            Console.WriteLine($"w = {w}");
        }
        public static void main_task4()
        {
            Console.WriteLine("\nЗадача №4:");
            double a = -0.5, b = 15.5, x = -2.9, s = 0, w = 0;
            s = Math.Pow((Math.Pow(x, 2) + b), 0.5) - ((Math.Pow(b, 2) - 2 * a) / x);
            Console.WriteLine($"s = {s}");
            w = Math.Cos(Math.Pow(x, 3)) - (x / Math.Pow(Math.Pow(a, 2) + Math.Pow(b, 2), 0.5));
            Console.WriteLine($"w = {w}");
        }

        //! Самостоятельная работа 1-10
        public static void sr10_1()
        {
            Console.WriteLine("Задача №1. Введите величину Z:");
            double z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(
                $"Байт:     {z}\n" +
                $"Килобайт: {z / 1024}\n" +
                $"Мегабайт: {z / Math.Pow(1024, 2)}\n" +
                $"Гигабайт: {z / Math.Pow(1024, 3)}\n" +
                $"Терабайт: {z / Math.Pow(1024, 4)}\n");
        }
        public static void sr10_2()
        {
            Console.WriteLine("\nЗадача №2. Введите a, b:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(
                $"Сумма:        {a + b}\n" +
                $"Разность:     {a - b}\n" +
                $"Произведение: {a * b}\n" +
                $"Частное:      {a / b}\n");
        }
        public static void sr10_3()
        {
            Console.WriteLine("\nЗадача №3. Введите m1, m2, R:");
            double m1 = Convert.ToDouble(Console.ReadLine());
            double m2 = Convert.ToDouble(Console.ReadLine());
            double r = Convert.ToDouble(Console.ReadLine());
            double g = 6.67 * Math.Pow(10, -11);
            double f = g * (m1 * m2) / Math.Pow(r, 2);
            Console.WriteLine($"F = {f}");
        }
        public static void sr10_4()
        {
            Console.WriteLine("\nЗадача №4. Введите a, b, h:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double h = Convert.ToDouble(Console.ReadLine());
            double s = (a + b) * h;
            Console.WriteLine($"S = {s}");
        }
        public static void sr10_5()
        {
            Console.WriteLine("\nЗадача №5. Введите R и U:");
            double r = Convert.ToDouble(Console.ReadLine());
            double u = Convert.ToDouble(Console.ReadLine());
            double i = u / r;
            Console.WriteLine($"I = {i}");
        }
        public static void sr10_6()
        {
            Console.WriteLine("\nЗадача №6. Введите L(см):");
            int l = (int)(Convert.ToDouble(Console.ReadLine()) / 100);
            Console.WriteLine($"L(м) = {l}");
        }
        public static void sr10_7()
        {
            Console.WriteLine("\nЗадача №7. Введите R:");
            double r = Convert.ToDouble(Console.ReadLine());
            double d = 2 * Math.PI * r;
            double p = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"Длина окружности: {d}; Площадь круга: {p}");
        }
        public static void sr10_8()
        {
            Console.WriteLine("\nЗадача №8. Введите размер файла (байты):");
            int b = Convert.ToInt32(Console.ReadLine());
            int k = b / 1024;
            Console.WriteLine($"Кол-во килобайтов: {k}");
        }
        public static void sr10_9()
        {
            Console.WriteLine("\nЗадача №9. Введите a, b, c:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double cao = (Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2)) / 3;
            Console.WriteLine($"Среднее арифметическое: {cao}");
        }
        public static void sr10_10()
        {
            Console.WriteLine("\nЗадача №10. Введите a, b, c:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"Площадь треугольника: {s}");
        }

        //! Самостоятельная работа 1-5
        public static void sr5_1()
        {
            Console.WriteLine("Задача №1. Введите t:");
            double t = Convert.ToDouble(Console.ReadLine());
            double s = 3 * Math.Pow(t, 2) - 6 * t;
            Console.WriteLine($"Скорость тела: {s}");
        }
        public static void sr5_2()
        {
            Console.WriteLine("\nЗадача №2. Введите катет и гипотенузу:");
            double a = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double b = Math.Sqrt(Math.Pow(c, 2) - Math.Pow(a, 2));
            double p = 0.5 * a * b;
            Console.WriteLine($"Второй катет: {b}");
            Console.WriteLine($"Площадь треугольника: {p}");
        }
        static double sr5_3_sh(double x)
        {
            return (Math.Exp(x) - Math.Exp(-x)) / 2;
        }
        public static void sr5_3()
        {
            Console.WriteLine("\nЗадача №3. Введите x:");
            double x = Convert.ToDouble(Console.ReadLine());
            double yx = sr5_3_sh(x) * Math.Tan(x + 1) - Math.Pow(Math.Tan(2 + sr5_3_sh(x - 1)), 2);
            Console.WriteLine($"Значение функции: {yx}");
        }
        public static void sr5_4()
        {
            Console.WriteLine("\nЗадача №4. Введите катет и гипотенузу:");
            double a = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double b = Math.Sqrt(Math.Pow(c, 2) - Math.Pow(a, 2));
            double p = 0.5 * a * b;
            Console.WriteLine($"Второй катет: {b}");
            Console.WriteLine($"Площадь треугольника: {p}");
        }
        public static void sr5_5()
        {
            Console.WriteLine("\nЗадача №5. Введите a, b:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double x = (12 - b) * a;
            Console.WriteLine($"Корень уровнения: {x}");
        }
        //! Загрузка элементов
        public static void loading()
        {
            Console.WriteLine("\n< Основные задачи 1-4 >\n");
            main_task1();
            main_task2();
            main_task3();
            main_task4();
            Console.WriteLine("\n< Самостоятельная работа 1-10 >\n");
            sr10_1();
            sr10_2();
            sr10_3();
            sr10_4();
            sr10_5();
            sr10_6();
            sr10_7();
            sr10_8();
            sr10_9();
            sr10_10();
            Console.WriteLine("\n< Самостоятельная работа 1-5 >\n");
            sr5_1();
            sr5_2();
            sr5_3();
            sr5_4();
            sr5_5();
        }
    }


    class Pracrice2
    {
        public static void main_task1()
        {
            Console.WriteLine("\nЗадача №1. Введите скорость ветра:");
            double wind_speed = Convert.ToDouble(Console.ReadLine());
            string wind_character;
            if (wind_speed >= 0 && wind_speed <= 4)
            {
                wind_character = "слабый";
            }
            else if (wind_speed > 4 && wind_speed <= 10)
            {
                wind_character = "умеренный";
            }
            else if (wind_speed > 10 && wind_speed <= 18)
            {
                wind_character = "сильный";
            }
            else if (wind_speed > 18)
            {
                wind_character = "ураганный";
            }
            else
            {
                wind_character = "Неизвестный характер";
            }

            Console.WriteLine($"Характер ветра: {wind_character}");
        }
        public static void main_task2()
        {
            Console.WriteLine("\nЗадача №2. Введите длинну проводника: ");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите удельное сопротивление r1, r2, r3:");
            double r1 = Convert.ToDouble(Console.ReadLine());
            double r2 = Convert.ToDouble(Console.ReadLine());
            double r3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите площадь сечения s1, s2, s3:");
            double s1 = Convert.ToDouble(Console.ReadLine());
            double s2 = Convert.ToDouble(Console.ReadLine());
            double s3 = Convert.ToDouble(Console.ReadLine());
            double p1 = r1 * s1 / l;
            double p2 = r2 * s2 / l;
            double p3 = r3 * s3 / l;
            double p_max = p1;
            int p_num = 1;
            if (p2 > p_max)
            {
                p_max = p2;
                p_num = 2;
            }
            if (p3 > p_max)
            {
                p_max = p3;
                p_num = 3;
            }
            Console.WriteLine($"Проводник с наибольшим удельным сопротивлением ({p_max}) под номером {p_num}");
        }
        public static void main_task3()
        {
            Console.WriteLine("\nЗадача №3. Введите параметры A, B:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            if (b >= a)
            {
                Console.WriteLine("Ошибка в расчетах (B >= A)");
            }
            double valia = a - b;
            string max_name = "Вера";
            double difference = b - valia;
            if (valia > b)
            {
                max_name = "Валя";
                difference = valia - b;
            }
            Console.WriteLine($"Больше всех клубники набрала {max_name}, собрав больше на {difference} кг.");
        }
        public static void sr10_1()
        {
            Console.WriteLine("\nЗадача №1. Введите сумму депозита:");
            double s = Convert.ToDouble(Console.ReadLine());
            if (s < 50000)
            {
                s = s * 1.2;
            }
            else if (s >= 50000 && s <= 100000)
            {
                s = s * 1.22;
            }
            Console.WriteLine($"Сумма выплаты через год составит {s}");
        }
        public static void sr10_2()
        {
            Console.WriteLine("\nЗадача №2. Введите ваш стаж работы (лет):");
            double year = Convert.ToDouble(Console.ReadLine());
            string nad = "0%";
            if (year >= 5 && year < 10)
            {
                nad = "2%";
            }
            else if (year >= 10 && year < 20)
            {
                nad = "10%";
            }
            else
            {
                Console.WriteLine("Ошибка в расчете надбавки");
            }
            Console.WriteLine($"Ваша надбавка составит {nad}");
        }
        public static void sr10_3()
        {
            Console.WriteLine("\nЗадача №3. Введите сумму вашей зарплаты и стаж (лет):");
            double summa = Convert.ToDouble(Console.ReadLine());
            int year = Convert.ToInt32(Console.ReadLine());
            double nad = 1;
            if (year >= 5 && year < 10)
            {
                nad = 1.02;
            }
            else if (year >= 10 && year < 20)
            {
                nad = 1.1;
            }
            else
            {
                Console.WriteLine("Ошибка в расчете надбавки");
            }
            Console.WriteLine($"Ваша надбавка составит - {summa * nad - summa}, сумма с учетом надбавки - {summa * nad}");
        }
        public static void sr10_4()
        {
            Console.WriteLine("\nЗадача №4. Введите ваш стаж работы по специальности (лет):");
            int year = Convert.ToInt32(Console.ReadLine());
            int kf = 0;
            if (year < 2)
            {
                kf = 11;
            }
            else if (year >= 2 && year <= 5)
            {
                kf = 12;
            }
            else if (year > 5)
            {
                kf = 13;
            }
            else
            {
                Console.WriteLine("Ошибка в расчетах коэффициента");
            }
            Console.WriteLine($"Коэффицент на бюджетное место = {kf}");
        }
        public static void sr10_5()
        {
            Console.Write("\nЗадача №5. Введите время разговора (t): ");
            int t = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВведите  продолжительность разгора (мин) (dt): ");
            int dt = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВведите стоимость минуты разговора (s): ");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВведите день недели (d): ");
            string d = Console.ReadLine() ?? "";
            double sum = s * dt;

            if ((t >= 22 && t <= 24) || (t >= 0 && t <= 8))
            {
                sum = sum * 0.9;
            }
            else if (string.Equals(d, "Суббота", StringComparison.OrdinalIgnoreCase) || string.Equals(d, "Воскресенье", StringComparison.OrdinalIgnoreCase))
            {
                sum = sum * 0.95;
            }
            Console.WriteLine($"Стоимость переговоров: {sum}");
        }
        public static void sr10_6()
        {
            Console.WriteLine("\nЗадача №6. Введите  продолжительность разгора (мин) (dt):");
            int dt = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВведите стоимость минуты разговора (s): ");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВведите день недели от 1 до 7 (d): ");
            int d = Convert.ToInt32(Console.ReadLine());
            double sum = s * dt;
            if (d == 6 || d == 7)
            {
                sum = sum * 0.9;
            }
            Console.WriteLine(
                $"На территории РФ (0.35 руб.): {sum * 0.35}\n" +
                $"Со странами ЕАЭС (0.90 руб.): {sum * 0.9}\n" +
                $"Со странами ЕС (1,5 руб.):    {sum * 1.5}"
            );
        }
        public static void sr10_7()
        {
            Console.WriteLine("Задача №7. Введите год:");
            int year = Convert.ToInt32(Console.ReadLine());
            string result = "Не високосный";
            if (year > -45 && year != 0 && (year < -9 || year > 9))
            {
                if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                {
                    result = "Високосный";
                }
            }
            else
            {
                result = "Недопустимый год";
            }
            Console.WriteLine(result);
        }
        public static void sr10_8()
        {
            Console.WriteLine("\nЗадача №8. Введите число от 1 до 12:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num >= 1 && num <= 12)
            {
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Январь - Зима");
                        break;
                    case 2:
                        Console.WriteLine("Февраль - Зима");
                        break;
                    case 3:
                        Console.WriteLine("Март - Весна");
                        break;
                    case 4:
                        Console.WriteLine("Апрель - Весна");
                        break;
                    case 5:
                        Console.WriteLine("Май - Весна");
                        break;
                    case 6:
                        Console.WriteLine("Июнь - Лето");
                        break;
                    case 7:
                        Console.WriteLine("Июль - Лето");
                        break;
                    case 8:
                        Console.WriteLine("Август - Лето");
                        break;
                    case 9:
                        Console.WriteLine("Сентябрь - Осень");
                        break;
                    case 10:
                        Console.WriteLine("Октябрь - Осень");
                        break;
                    case 11:
                        Console.WriteLine("Ноябрь - Осень");
                        break;
                    case 12:
                        Console.WriteLine("Декабрь - Зима");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Введен неправильный номер месяца");
            }
        }
        public static void sr10_9()
        {
            Console.WriteLine("\nЗадача №9. Введите три числа:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double[] numbers = { a, b, c };
            double max = numbers.Max();
            Console.WriteLine($"Максимальный элемент: {max}");
        }
        public static void sr10_10()
        {
            Console.WriteLine("\nЗадача №10. Введите число от 1 до 99:");
            int number = Convert.ToInt32(Console.ReadLine());
            string name = "копеек";
            if (number >= 1 && number <= 99)
            {
                if (number % 10 == 1 && number != 11)
                {
                    name = "копейка";
                }
                else if ((number % 10 == 2 || number % 10 == 3 || number % 10 == 4) && number != 12 && number != 13 && number != 14)
                {
                    name = "копейки";
                }
            }
            else
            {
                Console.WriteLine("Неизвестное число");
                return;
            }
            Console.WriteLine($"{number} {name}");
        }
        public static void loading()
        {
            Console.WriteLine("\n< Основные задачи 1-3 >\n");
            main_task1();
            main_task2();
            main_task3();
            Console.WriteLine("\n< Самостоятельная работа 1-10 >\n");
            sr10_1();
            sr10_2();
            sr10_3();
            sr10_4();
            sr10_5();
            sr10_6();
            sr10_7();
            sr10_8();
            sr10_9();
            sr10_10();
        }
    }

    //! Класс запуска
    class labaratory_work
    {
        static void Main()
        {
            // Practice1.loading();
            Pracrice2.loading();
        }
    }

}
