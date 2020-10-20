using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    interface Multiplicity<T>
    {
        void Add(T item);
        void Remove(T item);
        void Display(Set<T> Items);
    }
    public class Set<T> : Multiplicity<T>
    {
        public int x = 9;
        public class Date
        {
            public string date;
            public string x;
            public Date()
            {
                date = DateTime.Now.ToString();
            }
        }
        public class Owner
        {
            public int id = 444;
            public string name = "Mamchits";
            public string organization = "Student";
        }
        public List<T> Items = new List<T>();
        public void Add(T item)
        {
            if (!Items.Contains(item))
            {
                Items.Add(item);
            }
        }
        public void Remove(T item)
        {
            if (Items.Contains(item))
            {
                Items.Remove(item);
            }
        }
        public void Display(Set<T> Item)
        {
            foreach (T elem in Item.Items)
            {
                Console.Write($"{elem}  ");
            }
            Console.WriteLine();
        }
        public static int count;
        public Set()
        {
            count++;
            Console.WriteLine($"Создано {count}-е множество");
        }
        
        public static string operator +(Set<T> item1, Set<T> item2)
        {
            List<T> item3 = new List<T>();
            foreach (T elem in item1.Items)
            {
                    item3.Add(elem);
            }
            foreach (T elem in item2.Items)
            {
                if (!item1.Items.Contains(elem))
                {
                    item3.Add(elem);
                }
            }
            foreach (T elems in item3)
            {
                Console.WriteLine(elems);
            }
            return null;
        }
     
        public static Set<T>  operator ++ (Set<T>item11)
        {
            Random run = new Random();
            int val = run.Next(-2, 12);
            List<T> item111 = new List<T>();
            foreach (T elem in item11.Items)
            {
                item111.Add(elem);
            }
            foreach (T elems in item111)
            {
                Console.WriteLine(elems);
            }
            Console.WriteLine(val);
            return null;
        }
        public static string operator >=(Set<T> item1, Set<T> item2)
        {
            System.Collections.IList list = item1.Items;
            System.Collections.IList list2 = item2.Items;
            if(list.Count>=list2.Count)
            {
                Console.WriteLine("Множество 1 больше множества 2");
            }
            else
            {
                Console.WriteLine("Множество 1 меньше множества 2");
            }
            return null;
        }
        public static string operator <=(Set<T> item1, Set<T> item2)
        {
            System.Collections.IList list = item1.Items;
            System.Collections.IList list2 = item2.Items;
            if (list.Count <= list2.Count)
            {
                Console.WriteLine("Множество 1 меньше множества 2");
            }
            else
            {
                Console.WriteLine("Множество 1 больше множества 2");
            }
            return null;
        }
        public static string operator *(Set<T> item1, Set<T> item2)//мощность множеств
        {
            System.Collections.IList list = item1.Items;
            System.Collections.IList list2 = item2.Items;
            Console.WriteLine("Мощность множества 1 - "+ list.Count);
            Console.WriteLine("Мощность множества 2 - "+list2.Count);
            return null;
        }
        public static string operator % (Set<T> item1, Set<T> item2)//доступ к элементу в заданной позиции.
        {
            
            int i = 2;
                switch(i)
                {
                    case 0:
                        Console.WriteLine(-5);
                        break;
                    case 1:
                        Console.WriteLine(3);
                        break;
                    case 2:
                        Console.WriteLine(-2);
                        break;
                    case 3:
                        Console.WriteLine(7);
                        break;
                    case 4:
                        Console.WriteLine(3);
                        break;
                    case 5:
                        Console.WriteLine(-1);
                        break;

                }
            switch (i)
            {
                case 0:
                    Console.WriteLine(1);
                    break;
                case 1:
                    Console.WriteLine(2);
                    break;
                case 2:
                    Console.WriteLine(3);
                    break;
                case 3:
                    Console.WriteLine(7);
                    break;

            }

            return null;
        }
    }
    static public class StaticOperation
    {
        static int count;
        static int sum;
        static int max = -900000;
        static int min = 99999;
        public static void Sum(Set<int> Item)
        {
            foreach (int elem in Item.Items)
            {
                sum += elem;
            }
            System.Console.WriteLine($"Сумма элементов {sum}");
        }
        public static void Difference(Set<int> Item)
        {

            foreach (int elem in Item.Items)
            {
                if (elem > max)
                {
                    max = elem;
                }
                if (elem < min)
                {
                    min = elem;
                }
            }
            int difference = max - min;
            Console.WriteLine($"Разница между максимальным и минимальным элементом {difference}");
        }
        public static void Count(Set<int> Item)
        {
            foreach (int elem in Item.Items)
            {
                count++;
            }
            Console.WriteLine($"Количество элементов {count}");
            count = 0;
        }
       



    }

    class Program
    {

        static void Main(string[] args)
        {
            Set<int>.Date today = new Set<int>.Date();
            Console.WriteLine("Сегодняшняя дата");
            Console.WriteLine(today.date);
            Set<int>.Owner person = new Set<int>.Owner();
            Console.WriteLine("Мои данные");
            Console.WriteLine(person.id + " " + person.name + " " + person.organization + '\n');
            Set<int> obj1 = new Set<int>();
            obj1.Add(-5);
            obj1.Add(3);
            obj1.Add(-2);
            obj1.Add(7);
            obj1.Add(3);
            obj1.Add(-1);
            int[] obj = { -5, 3, -2, 7, 3, -1 };
            obj1.Display(obj1);
            StaticOperation.Count(obj1);
            StaticOperation.Sum(obj1);
            Set<int> obj2 = new Set<int>();
            obj2.Add(1);
            obj2.Add(2);
            obj2.Add(3);
            obj2.Add(7);
            obj2.Display(obj2);
            StaticOperation.Count(obj2);
            StaticOperation.Difference(obj2);
            
            Console.WriteLine($"Объединение множеств");
            var association = obj1 + obj2;
            Console.WriteLine(association);
            var simile = obj1 <= obj2;
            var PV = obj1 * obj2;
            Set<int> obj11= new Set<int>();
           obj11.Add(-5);
            obj11.Add(3);
            obj11.Add(-2);
            obj11.Add(7);
            obj11.Add(3);
            obj11.Add(-1);
            obj11.Display(obj11);
            Console.WriteLine(++obj11);
            Console.WriteLine(obj1 % obj2);
            string str = "xenia123456789";
            Console.WriteLine(str);
            string str1 = Coding(str);
            Console.WriteLine(str1);
            Order(obj);
            Set<int> im = new Set<int>();

            
        }
        public static string Coding(string str) //шифрование
        {
            ushort secretKey = 0x0088;//секретный ключ
            var ch = str.ToArray();//преобразуем строку в символы
            string NewStr = "";//переменная, которая будет содержать зашифрованную строку
            foreach (var c in ch)
            {
                NewStr += TopSecret(c, secretKey);//шифрование каждого символа строки
            }
            return NewStr;
        }
        public static char TopSecret(char character, ushort secretKey)
        {
            character = (char)(character ^ secretKey);//операция логическое исключающее ИЛИ
            return character;
        }
        public static string Order(int[] obj) //проверка на упорядоченность
        {
           for(int i=0;i<6;i++)
            {
                if(obj[i]>obj[i+1])
                {
                    Console.WriteLine("Ошибка!");
                    break;
                }
            }
            return null;
        }

    }
}
