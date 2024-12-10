using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Messenger<T> where T : IMessage
    {
        public void Send(T message)
        {
            Console.WriteLine($"Sending {message.GetType().Name}: {message.Content}");
        }
    }
}
