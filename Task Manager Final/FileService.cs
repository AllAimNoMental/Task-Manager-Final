using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using TaskBase1;

namespace Task_Manager_Final
{
    public class FileService
    {
        public async Task SaveTask(List<TaskBase> list)
        {
            string json = JsonSerializer.Serialize(list);
            await File.WriteAllTextAsync("json.txt", json);
        }

    

    public async Task<List<TaskBase>> LoadTasks()
        {
            if (!File.Exists("json.txt"))
            {
                return new List<TaskBase>();
            }
            string DeserealizeJson = await File.ReadAllTextAsync("json.txt");
            return JsonSerializer.Deserialize<List<TaskBase>>("json.txr");
        }
    }
}
