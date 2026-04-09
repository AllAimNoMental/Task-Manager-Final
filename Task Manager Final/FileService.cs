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
            await Task.Delay(1000);
            string json = JsonSerializer.Serialize(list);
            await File.WriteAllTextAsync("json.txt", json);
        }

    

    public async Task<List<TaskBase>> LoadTasks()
        {

            await Task.Delay(1000);
            if (!File.Exists("json.txt"))
            {
                return new List<TaskBase>();
            }
            string DeserealizeJson = await File.ReadAllTextAsync("json.txt");
            return JsonSerializer.Deserialize<List<TaskBase>>("json.txr");
        }
    }
}
