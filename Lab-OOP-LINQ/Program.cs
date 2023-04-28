using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_OOP_LINQ
{
    public struct student
    {
        public string Name;
        public string Surname;
        public string Topic;

        public student(string Name, string Surname, string Topic)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Topic = Topic;
        }
    }

    class Program
    {
        //-------------> ЧЕРЕЗ LINQ <-------------
        static void Main(string[] args)
        {
            List<student> Students = new List<student>()
            {
                new student("Никита", "Котвицкий", "HDD и SSD"),
                new student("Александр", "Фролов", "Операционные системы"),
                new student("Никита", "Корнеев", "Веб-дизайн"),
                new student("Максим", "Хрол", "Октябрьская революция"),
                new student("Илья", "Кузьменко", "Базы данных, SQL-запросы"),
                new student("Сергей", "Сахаров", "Веб-разработка")
            };

            void Print()
            {
                foreach (student item in Students)
                {
                    Console.WriteLine($"{item.Name}, {item.Surname}, {item.Topic}");
                }
            }

            Print();

            bool ison = true;
            while (ison)
            {
                Console.WriteLine("Какое действие хотите выполнить?");
                Console.WriteLine("1-удалить выступление, 2-добавить выступление, 3-редактировать выступление, 4-поиск выступающего по имени, 5-ВЫХОД");

                int choice = 0;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Введите Фамилию студента, которое нужно удалить: ");
                        string name_ = Console.ReadLine();

                        Students.RemoveAll(s => s.Surname == name_);   

                        Console.WriteLine("Редактированное выступление на конференции: ");
                        Print();
                        break;

                    case 2:
                        Console.WriteLine("Введите новое имя, фамилию и тему доклада через Enter: ");
                        List<student> studentAdd = new List<student>();   
                        
                        Students.Add(new student() { Name = Console.ReadLine(), Surname = Console.ReadLine(), Topic = Console.ReadLine() });

                        Console.WriteLine("Редактированное выступление на конференции: ");
                        Print();
                        break;

                    case 3:
                        Console.WriteLine("Введите фамилию выступающего, которого нужно изменить: ");

                        string _find = Console.ReadLine();
                        student _user = Students.Find(item => item.Name == _find);

                        Console.WriteLine("Изменить: 1 - Имя пользователя, 2 - Фамилия, 3 - Тема доклада");
                        int _num = int.Parse(Console.ReadLine());

                        if (_num == 1)
                        {
                            for (int i = 0; i < Students.Count; ++i)
                            {
                                if (Students[i].Surname == _find)
                                {
                                    _user = Students[i];
                                    Console.WriteLine("Введите новое имя:");
                                    _user.Name = Console.ReadLine();
                                    Students[i] = _user;
                                }
                            }
                        }

                        else if (_num == 2)
                        {
                            for (int i = 0; i < Students.Count; ++i)
                            {
                                if (Students[i].Surname == _find)
                                {
                                    _user = Students[i];
                                    Console.WriteLine("Введите новую фамилию:");
                                    _user.Surname = Console.ReadLine();
                                    Students[i] = _user;
                                }
                            }
                        }

                        else if (_num == 3)
                        {
                            for (int i = 0; i < Students.Count; ++i)
                            {
                                if (Students[i].Surname == _find)
                                {
                                    _user = Students[i];
                                    Console.WriteLine("Введите новую тему доклада:");
                                    _user.Topic = Console.ReadLine();
                                    Students[i] = _user;
                                }
                            }
                        }

                        Console.WriteLine("Редактированное выступление на конференции: ");
                        Print();
                        break;

                    case 4:
                        Console.WriteLine("Введите фамилию студента, которого нужно найти: ");
                        string find = Console.ReadLine();
                        var studentFind = Students.Find(s => s.Surname == find);

                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine($"Имя: {studentFind.Name}, Фамилия: {studentFind.Surname}, Тема доклада: {studentFind.Topic}");
                        Console.ResetColor();
                        break;

                    case 5:
                        ison = false;
                        break;

                    default:
                        Console.WriteLine("Такого варианта нет, попробуйте снова...");
                        break;
                }
            }
        }
    }
}