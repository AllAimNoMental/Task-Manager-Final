using FileService1;
using PersonalTask1;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading.Tasks;
using TaskBase1;
using TaskBase1;
using TaskManager1;
using WorkTask1;
using FileService1;

public class Program
{
    
    static async Task Main()
    {
        TaskManager listOfTasks = new TaskManager();
        FileService json = new FileService();

        bool loop = true;
        while (loop)
        {
            ShowMenu();
            int inputMenu = int.Parse(Console.ReadLine());

            switch (inputMenu)
            {
                case 1:
                    AddingProcess(listOfTasks);

                    break;
                case 2:
                    Console.WriteLine($"Tasks added: {listOfTasks.Tasks.Count}");
                    listOfTasks.ViewTasks();
                    break;
                case 3:
                    DeletingProcess(listOfTasks);
                    break;
                case 4:
                    MarkingCompleted(listOfTasks);
                    break;
                case 5:
                    FilteringProcess(listOfTasks);
                    break;
                case 6:

                    await json.SaveTask(listOfTasks.Tasks);
                    listOfTasks.Tasks = await json.LoadTasks();
                    break;
                case 7:
                    loop = false;
                    break;


            }
        }







    }
    static void ShowMenu()
    {
        Console.WriteLine("Welcome to task manager");
        Console.WriteLine("1.Add Task");
        Console.WriteLine("2.View Task");
        Console.WriteLine("3.Delete Task");
        Console.WriteLine("4.Mark Complete");
        Console.WriteLine("5.Filtering");
        Console.WriteLine("6.Json");
        Console.WriteLine("7.Exit ");

    }
    static void AddingProcess(TaskManager listTask)
    {
        bool loop = true;
        while (loop)
        {
            Console.WriteLine("Please enter the information of the  task that you want to add");
            Console.Write("Tittle: ");
            string tittle = Console.ReadLine();
            Console.WriteLine("Priority(low1, medium2, high3): ");
            Priority priority;
            int priorityInput = int.Parse(Console.ReadLine());
            if (priorityInput == 1)
            {
                priority = Priority.Low;
            }
            else if (priorityInput == 2)
            {
                priority = Priority.Medium;
            }
            else if (priorityInput == 3)
            {
                priority = Priority.High;
            }
            else
            {
                Console.WriteLine("Invalid Option");
                return;
            }
            bool loop1 = true;
            while (loop1)
            {
                Console.WriteLine("Please choose the date(yyyy-MM-dd): ");
                string dateInput = Console.ReadLine();
                DateTime date;
                if (DateTime.TryParse(dateInput, out date))
                {
                    loop1 = false;
                    Console.WriteLine("What kind of task it is, Personal or Work");
                    string typeOfTask = Console.ReadLine().ToLower().Trim();
                    TaskBase task;
                    if (typeOfTask == "personal")
                    {
                        task = new PersonalTask(tittle, priority, date);

                    }
                    else if (typeOfTask == "work")
                    {
                        task = new WorkTask(tittle, priority, date);
                    }
                    else
                    {
                        Console.WriteLine("Invalid option ");
                        return;
                    }

                    listTask.AddTask(task);

                    Console.WriteLine("If u want to add more tasks press enter if not type exit");
                    string inputExit = Console.ReadLine().ToLower().Trim();
                    if (inputExit == "exit")
                    {
                        loop = false;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid date");
                }
            }
            


        }
    }
    static void DeletingProcess(TaskManager listTaskToDelete)
    {
        listTaskToDelete.Deleting();
    }
    static void MarkingCompleted(TaskManager tasksToComplete)
    {
        tasksToComplete.CompleteTask();
    }
    static void FilteringProcess(TaskManager Filtering)
    {
        Filtering.Filtering();
    }
}