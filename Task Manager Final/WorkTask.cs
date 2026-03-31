using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;
using TaskBase1;

namespace WorkTask1
{
    public  class WorkTask: TaskBase
    {
      public WorkTask(string title,Priority priority, DateTime duedate ) : base(title, priority, duedate) { }
    }
}
