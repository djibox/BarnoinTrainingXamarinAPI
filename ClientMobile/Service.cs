using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ClientMobile
{
    public class Service
    {
        private string Url = "http://barnoinapi.azurewebsites.net/api/TodoItems";

        public async Task<List<TodoItem>> GetTodos()
        {
            var httpClient = new HttpClient();

            var json = await httpClient.GetStringAsync(Url);

            var todoes = JsonConvert.DeserializeObject<List<TodoItem>>(json);

            return todoes;
        }

        public async Task PostTodos(TodoItem todoItem)
        {
            var httpClient = new HttpClient();

            var json = JsonConvert.SerializeObject(todoItem);

            StringContent content = new StringContent(json);

            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var result = await httpClient.PostAsync(Url, content);

        }
    }
}
