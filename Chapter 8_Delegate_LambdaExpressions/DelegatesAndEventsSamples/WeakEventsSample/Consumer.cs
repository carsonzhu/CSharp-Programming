﻿using System;
using System.Windows;

namespace Wrox.ProCSharp.Delegates
{
    public class Consumer : IWeakEventListener      //实现IWeakEventListener接口
    {
        private string name;

        public Consumer(string name)
        {
            this.name = name;
        }

        public void NewCarIsHere(object sender, CarInfoEventArgs e)
        {
            Console.WriteLine("{0}: car {1} is new", name, e.Car);
        }

        bool IWeakEventListener.ReceiveWeakEvent(Type managerType, object sender, EventArgs e)      //触发事件时，从弱事件管理器中调用IWeakEventListener定义的ReceiveWeakEvent方法
        {
            NewCarIsHere(sender, e as CarInfoEventArgs);
            return true;
        }


    }
}
