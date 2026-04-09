using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;


namespace TaskBase1
{
    public abstract class TaskBase
    {
        public string Title { get; set; }

       public  Priority Priority { get; set; }
        public DateTime DueDate { get; set; }
        public bool Completed { get; set; }
        public virtual void Display()
        {
            Console.WriteLine($"Tittle: {Title}|| Due: {DueDate}|| Completed: {Completed}|| Priority: {Priority}");
        }
        public TaskBase(string title, Priority priority, DateTime dueDate)
        {
            Title = title;
            Priority = priority;
            DueDate = dueDate;  
            Completed = false;

        }
    }
    public enum Priority
    {
        Low = 1, Medium,High
    }


}
