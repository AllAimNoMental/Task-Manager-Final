using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using TaskBase1;

namespace FileService1
{
    public class FileService
    {
        public async Task SaveTask(List<TaskBase> list)
        {
            string path = @"C:\Users\luisc\source\repos\Task Manager Final\Task Manager Final\json.txt";
            await Task.Delay(1000);
            string json = JsonSerializer.Serialize(list);
            await File.WriteAllTextAsync(path, json);
        }

    

    public async Task<List<TaskBase>> LoadTasks()
        {
            string path = @"C:\Users\luisc\source\repos\Task Manager Final\Task Manager Final\json.txt";
            await Task.Delay(1000);
            if (!File.Exists("json.txt"))
            {
                return new List<TaskBase>();
            }
            string DeserealizeJson = await File.ReadAllTextAsync(@"C:\Users\luisc\source\repos\Task Manager Final\Task Manager Final\json.txt");
            return JsonSerializer.Deserialize<List<TaskBase>>( @"C:\Users\luisc\source\repos\Task Manager Final\Task Manager Final\json.txt");
        }
    }
}
