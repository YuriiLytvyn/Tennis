using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servises;
using Model;

namespace ConsoleApp
{
    class View
    {

        SchoolService logic;
        public void Menu()
        {


            bool x = true;
            while (x)
            {
                Console.WriteLine("Please choose an option");
                Console.WriteLine("1.Add child");
                Console.WriteLine("2.Show all groups with children");
                Console.WriteLine("3.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter name and surname");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter age");
                            int age = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter level of training (1 for beginner , 2 for amateur , 3 for professional)");
                            int level = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter day");
                            int day = Convert.ToInt32(Console.ReadLine());

                            logic.CreateChild(name, age, level, (Days)day);
                        }
                        break;

                    case 2:
                        {
                            List<Group> groups = logic.AllGroups();

                            foreach (Group group in groups)
                            {
                                Console.WriteLine("Group : ");
                                Console.WriteLine(group);
                                foreach (Child child in group.childrens)
                                {
                                    Console.WriteLine(child);
                                };
                            };

                        }
                        break;

                    case 3:
                        {
                            Console.WriteLine("You chose to quit.");

                            x = false;
                            break;
                        }
                }


            }

        }

        public View(SchoolService _controller)
        {
            this.logic = _controller;
        }
    }
}
