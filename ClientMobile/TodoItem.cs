﻿using System;
namespace ClientMobile
{
    public class TodoItem
    {
        public TodoItem()
        {
        }

        public long Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public bool IsComplete
        {
            get;
            set;
        }
    }
}
