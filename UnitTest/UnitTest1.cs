using TaskManager1;
using TaskBase1;
using PersonalTask1;
using WorkTask1;


namespace UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void AddingTask()
        {
            TaskManager manager = new TaskManager();

            WorkTask task = new WorkTask("math", Priority.High, new DateTime(2026 , 06 , 20));


            Assert.Single(manager.Tasks);
            Assert.Equal(task, manager.Tasks[0]);
        }

    }
}
