using System;
/*
Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
а) используя  склеивание;
	б) используя форматированный вывод;
	в) используя вывод со знаком $.
Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.


а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
Написать программу обмена значениями двух переменных:
а) с использованием третьей переменной;
	б) *без использования третьей переменной.
а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
б) *Сделать задание, только вывод организовать в центре экрана.

Страхов Сергей Вадимович*/

//ВОПРОС: если я хочу сделать собственный метод Print то мне необходимо создать несколько перегруженных методов, в параметрах кототорых будут разные типы переменных?

namespace HellowWord
{
    class ManValue
    {   //имя, фамилия, возраст, рост, вес

        static void Main(string[] args)
        {
            Console.Write("Введите имя:");
            string firstname = Console.ReadLine();

            Console.Write("Введите фамилию:");
            string secondname = Console.ReadLine();

            /* Console.Write("Введите возраст:");
             int age = Convert.ToInt32(Console.ReadLine());
             string ageFormat = String.Format("{0:d}", age);

             Console.Write("Введите рост:");
             double hight = Convert.ToDouble(Console.ReadLine());
             string hightFormat = String.Format("{0:f}", hight);

             Console.Write("Введите вес:");
             double mass = Convert.ToDouble(Console.ReadLine());
             string massFormat = String.Format("{0:f}", mass);

             Console.WriteLine("Имя: " + firstname + " Фамилия: " + secondname + " Возраст: " + age + " Рост: " + hight + " Вес: " + mass);
             Console.WriteLine("Имя: " + firstname + " Фамилия: " + secondname + " Возраст: " + ageFormat + " Рост: " + hightFormat + " Вес: " + massFormat);
             Console.WriteLine($"Имя: {firstname}  Фамилия: {secondname}  Возраст: {age} Рост: {hight} Вес: {mass}");

             static double IndexMass(double hight, double mass)
             {
                 double Index = mass / (hight * hight);
                 return Index;
             }

             Console.WriteLine ("Ваш индекс массы " + IndexMass(hight, mass));

             static double LengthStraight(double x1, double y1, double x2, double y2)
             {
                 double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Sqrt(Math.Pow(y2 - y1, 2)));
                 return length;
             }

             Console.WriteLine("Расстояние между точками " + "{0:f2}", LengthStraight(2, 2, 4, 4));*/

            /*
            static void Swap(int a, int b)
            {
                //Пример с третьей переменной
                int c = 0;
                
                Console.WriteLine("Переменные до обмена: " + "a= " + a + " " + "b= " + b);
                c = a;
                a = b;
                b = c;
                Console.WriteLine("Переменные после обмена: " + "a= " + a + " " + "b= " + b);

                //Пример без лишней переменной
                Console.WriteLine("Переменные до обмена: " + "a= " + a + " " + "b= " + b);
                a = a + b;
                b = b - a;
                b = -b;
                a = a - b;
                Console.WriteLine("Переменные до обмена: " + "a= " + a + " " + "b= " + b);
            }*/

            //Swap(2, 3);

            static void CenterPosition(string a, string b)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                Console.WriteLine(a + " " + b);
            }

            CenterPosition(firstname, secondname);
            Console.ReadKey();
        }
    }

    class Help
    {
       /* public static void Print(string a)
        {
            Console.WriteLine(a);
        }*/
           
        public static void Pause()
        {
            Console.ReadKey();
        }
    }
}

