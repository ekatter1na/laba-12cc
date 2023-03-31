using System;

namespace Laba_12cc
{

    class EventDelegateClass
    {
        private string name;

        public delegate void EventDelegate(string txt);
        public EventDelegateClass(string name)
        {
            this.name = name;
        }
        public event EventDelegate Event;
        public void MyEvent()
        {
            if (Event != null)
            {
                Event(name);
            }
        }
    }
    class Class
    {
        private string text;
        public Class(string metodtext)
        {
            text = metodtext;
        }
        public void show(string objname)
        {
            Console.WriteLine("Объект, сгенерировавший событие: " + objname);
            Console.WriteLine("Сообщение: " + text);
        }
    }
    class Program
    {
        static void Main()
        {
            EventDelegateClass Odject1 = new EventDelegateClass("объект1");
            EventDelegateClass Odject2 = new EventDelegateClass("объект2");

            Class ClassObjectt = new Class("объект класса");

            Odject1.Event += ClassObjectt.show;
            Odject2.Event += ClassObjectt.show;

            Odject1.MyEvent();
            Console.WriteLine();

            Odject2.MyEvent();
            Console.WriteLine();
        }
    }
}