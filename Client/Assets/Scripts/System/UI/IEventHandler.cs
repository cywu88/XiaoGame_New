﻿using System;
using System.Collections.Generic;

using System.Text;

 namespace RedStone.UI
{
    public interface IEventHandler
    {
        void OnEvent(string sender, params object[] args);
    }
}