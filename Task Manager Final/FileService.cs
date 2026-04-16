using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using TaskBase1;

namespace FileService1
{
    public class FileService
    {
        public async Task SaveTasks(List<TaskBase> list)
        {
            string path = @"C:\Users\luisc\source\repos\Task Manager Final\Task Manager Final\data.json";
          
            await Task.Delay(1000);
            string json = JsonSerializer.Serialize(list);
            await File.WriteAllTextAsync(path, json);
        }

    

    public async Task<List<TaskBase>> LoadTasks()
        {
            string path = @"C:\Users\luisc\source\repos\Task Manager Final\Task Manager Final\data.json";
            await Task.Delay(1000);
            if (!File.Exists("data.json"))
            {
                return new List<TaskBase>();
            }
            string data = await File.ReadAllTextAsync(path);
            if (!string.IsNullOrEmpty(data))
            {
                return JsonSerializer.Deserialize<List<TaskBase>>(data);
            }
            return new List<TaskBase>();
        }
    }
}
