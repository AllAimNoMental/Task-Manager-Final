using PersonalTask1;
using System;
using System.Reflection;
using TaskBase1;
using TaskManager1;
using WorkTask1;


namespace UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void AddingTask()
        {
            TaskManager manager = new TaskManager();

            WorkTask task = new WorkTask("math", Priority.High, new DateTime(2026, 06, 20));

            manager.AddTask(task);
            Assert.Single(manager.Tasks);
            Assert.Equal(task, manager.Tasks[0]);
        }

        [Fact]
        public void Deleting()
        {
            TaskManager manager = new TaskManager();

            WorkTask task = new WorkTask("math", Priority.High, new DateTime(2026, 06, 20));
            manager.AddTask(task);
            manager.DeletingLogic(1);

            Assert.Empty(manager.Tasks);
            Assert.DoesNotContain(task, manager.Tasks);
        }

        [Fact]
        public void Completing()
        {
            TaskManager manager = new TaskManager();

            WorkTask task = new WorkTask("math", Priority.High, new DateTime(2026, 06, 20));
            manager.AddTask(task);
            manager.CompleteTasKLogic(1);
            Assert.True(task.Completed);

        }

        //Single → cantidad exacta
        //Equal → comparar valores
        //Contains → está en lista
        //DoesNotContain → no está
        //True / False → condiciones
        //NotNull → existe objeto

    }
}
