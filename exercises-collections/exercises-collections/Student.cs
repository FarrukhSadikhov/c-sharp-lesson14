using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace exercises_abstract_classes
{
    class Student : Person
    {
        ArrayList list = new ArrayList();
        public override void Print()
        {
            if (list.Count != 0)
            {
                foreach (object student in list)
                {
                    Console.WriteLine(student);
                }
            }
            else
            {
                Console.WriteLine("\nСписок студентов пуст.\n");
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
                        Console.WriteLine(list[i]);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Такого имени нет!\n");
            }
        }
        public override void Addition()
        {
            Console.Write($"Введите фамилию студента:  ");
            Surname = Program.CheckString();
            Console.Write($"Введите номер курса: ");
            Course = Program.CheckNumber();
            Console.Write($"Введите номер зачетной книги: ");
            GradeBook = Program.CheckNumber();
            list.Add($"Фамилию  студента: {Surname}\nНомер курса:{Course}\nНомер зачетной книги: {GradeBook}\n");
        }
        public override void RemoveAt()
        {
            try
            {
                Console.WriteLine("Удалить по индексу стуента:  ");
                int number = Program.CheckNumber();
                list.RemoveAt(number - 1);
                Console.WriteLine("Студент удалился!Проверьте список\n");
            }
            catch (Exception)
            {
                Console.WriteLine("Студента под таким индексом нет!!!\n");
            }
        }
        public override void Count()
        {
            Console.WriteLine($"\nКоличество студентов : {list.Count}\n");
        }
    }
}

