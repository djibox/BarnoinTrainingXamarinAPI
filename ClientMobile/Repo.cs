using System;
using System.Collections.Generic;

namespace ClientMobile
{
    public class Repo
    {
        public readonly Service service;
        public Repo()
        {
            service =new Service();
            GetTodos();
        }

        public List<TodoItem> todos { get; set; }

        public async void GetTodos()
        {
            todos = await service.GetTodos();
        }
    }
}
