using PersonalTask1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskBase1;
using WorkTask1;

namespace TaskManager1
{
    public class TaskManager
    {
        private List<TaskBase> Tasks = new List<TaskBase>();
        public void AddTask(TaskBase task)
        {
            Tasks.Add(task);
        }
        public void ViewTasks()
        {
            if (Tasks.Count >= 0)
            {
                for (int i = 0; i < Tasks.Count; i++)
                {
                    Console.WriteLine(i);
                    Tasks[i].Display();

                }
            }
            else
            {
                Console.WriteLine("The list is empty");
            }

        }

        public  void Deleting()
        {
            if (Tasks.Count == 0)
            {
                Console.WriteLine("The list is empty...");
                return;
            }
            Console.WriteLine("What task do you want to delete #.... ");
            ViewTasks();
            if (int.TryParse(Console.ReadLine(), out int inputUser))
            {
                if (inputUser >= 0 && inputUser < Tasks.Count)
                {
                    Tasks.RemoveAt(inputUser);
                    Console.WriteLine("Task succesfully deleted");
                }
                else
                {
                    Console.WriteLine("The index is wrong");
                }
            }
            else
            {
                Console.WriteLine("invalid option");

            }
                
                
            }
                

        
        public void Filtering()
        {
            Console.WriteLine("1.Task not Completed");
            Console.WriteLine("2.Task completed");
            Console.WriteLine("3.Task to  Highest to lowest priority");
            bool loop = true;

            while (loop)
            {
                int inputUSer = int.Parse(Console.ReadLine());
                if (inputUSer == 1)
                {
                    Console.WriteLine("Tasks not completed");

                    var notCompleted = Tasks.Where(t => t.Completed == false).ToList();
                    foreach (var task in notCompleted)
                    {
                        task.Display();
                    }
                }
                else if (inputUSer == 2)
                {
                    Console.WriteLine("Task completed");
                    var completed = Tasks.Where(t => t.Completed).ToList();

                    foreach (var task in completed)
                    {
                        task.Display();
                    }


                }
                else if (inputUSer == 3)
                {
                    Console.WriteLine("Highest to lowest");
                    var sorted = Tasks.OrderByDescending(t => t.Priority).ToList();
                    foreach (var task in sorted)
                    {
                        task.Display();
                    }
                }
                else
                {

                    Console.WriteLine("Invalid Option");
                }
                Console.WriteLine("If you want to exit the filtering menu type (exit), if not press enter");
                string inputUser = Console.ReadLine().ToLower();
                if (inputUser == "exit")
                {
                    loop = false;
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }


            }

        }
    }
}
