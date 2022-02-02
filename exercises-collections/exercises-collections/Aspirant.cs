using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace exercises_abstract_classes
{
    class Aspirant : Person
    {
        ArrayList arr = new ArrayList();

        protected string subject;

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }
        public override void Addition()
        {
            Console.Write($"Введите фамилию аспирант:  ");
            Surname = Program.CheckString();
            Console.Write($"Введите номер курса: ");
            Course = Program.CheckNumber();
            Console.Write($"Введите номер зачетной книги: ");
            GradeBook = Program.CheckNumber();
            Console.WriteLine($"Введите тему десертации: ");
            Subject = Program.CheckString();
            arr.Add($"Фамилию асперанта: {Surname}\nНомер курса:{Course}\nНомер зачетной книги: {GradeBook}\nTему десертации: {Subject}");
        }
        public override void RemoveAt()
        {       
            try
            {
                Console.WriteLine("Удалить по индексу аспиранта:  ");
                int number = Program.CheckNumber();
                arr.RemoveAt(number - 1);
                Console.WriteLine("Аспирант удалился!Проверьте список\n");
            }
            catch (Exception)
            {
                Console.WriteLine("Аспирант под таким индексом нет!!!\n");
            }
        }
        public override void Print()
        {
            if (arr.Count != 0)
            {
                foreach (object aspirant in arr)
                {
                    Console.WriteLine(aspirant);
                }
            }
            else
            {
                Console.WriteLine("\nСписок аспирант пуст.\n");
            }
        }
        public override void PrintIndex()
        {
            Console.WriteLine("Введите индекс ");
            int num = Program.CheckNumber();
            try
            {
                for (int i = 0; i < num; i++)
                {
                    if (num - 1 == i)
                    {
                        Console.WriteLine(arr[i]);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Такого имени нет!\n");
            }
        }
        public override void Count()
        {
            Console.WriteLine($"\nКоличество аспирантов: {arr.Count}\n");
        }
    }
}
