using Microsoft.VisualBasic;
using PersonalTask1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;
using WorkTask1;


namespace TaskBase1
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "type")]
    [JsonDerivedType(typeof(WorkTask),"work")]
    [JsonDerivedType(typeof(PersonalTask), "personal")]

    public abstract class TaskBase
    {
        public string Title { get; set; }

       public  Priority Priority { get; set; }
        public DateTime DueDate { get; set; }
        public bool Completed { get; set; }
        public virtual void ShowData()
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
