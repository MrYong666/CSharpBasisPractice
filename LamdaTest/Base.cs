using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaTest
{
    public class Base
    {
        public List<Personal> GetPersonals()
        {
            List<Personal> persons = new List<Personal>();
            persons.Add(new Personal("张,三", "男", 12, 1500, 123, DateTime.Now));
            persons.Add(new Personal("张三111", "男", 15, 1500, 123, DateTime.Now.AddDays(1)));
            persons.Add(new Personal("王成", "男", 32, 1700, 123, DateTime.Now.AddDays(2)));
            persons.Add(new Personal("李,丽", "女", 19, 1700, 22, DateTime.Now.AddDays(3)));
            persons.Add(new Personal("何英", "女", 35, 1700, 22, DateTime.Now.AddDays(4)));
            persons.Add(new Personal("何英", "中立", 18, 1655, 22, DateTime.Now.AddDays(5)));
            return persons;
        }
    }
    public class Personal
    {
        public string Name { get; set; }
        public int UserId { get; set; }
        public int Age { get; private set; }
        public string Sex { get; set; }
        public int Money { get; set; }
        public DateTime dt { get; set; }
        public Personal() { }
        public Personal(string name, string sex, int age, int money, int userId, DateTime dateTime)
        {
            Name = name;
            Age = age;
            Sex = sex;
            Money = money;
            UserId = userId;
            dt = dateTime;
        }
    }
}
