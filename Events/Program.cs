using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    /// <summary>
    /// 事件注册者;
    /// 事件注释： 事件是委托的封装，用于更加安全的Add和Remove委托，且保护委托链
    /// 原理：触发别的对象的行为
    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {
            Subscriber subscriber = new Subscriber();
            Publisher publisher = new Publisher();
            publisher.PublisherEvent += subscriber.Receive;
            publisher.Run();
        }
    }
    /// <summary>
    /// 发布者
    /// </summary>
    public class Publisher
    {
        public delegate void PublisherEventHandler();
        public event PublisherEventHandler PublisherEvent;
        public void Run()
        {
            Console.WriteLine("刊登了一则新闻！");
            if (PublisherEvent != null)
            {
                PublisherEvent();

            }
        }
    }
    /// <summary>
    /// 订阅
    /// </summary>
    public class Subscriber
    {
        public void Receive()
        {
            Console.WriteLine("收到消息,刊登了一则新闻!");
        }

    }
}
