using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaTest
{
    public class Group : Base
    {
        /// <summary>
        /// 分组后，先按照时间排序，然后获取每个分组后的时间最小的那条数据
        /// </summary>
        public void GroupTest()
        {
            var personal = GetPersonals();
            var t1 = personal.OrderByDescending(o => o.Age).GroupBy(g => g.UserId);
            var t2 = personal.OrderByDescending(o => o.Age).GroupBy(g => g.UserId, (key, group) => group.First());
            var t3 = personal.OrderByDescending(o => o.Age).GroupBy(g => g.UserId, (key, group) => group.First())
                    .Select(s => new Test1 { age = s.Age });
            var t4 = personal.OrderByDescending(o => o.Age)
                .GroupBy(g => g.UserId, (key, group) =>
                {
                    return group.OrderBy(o => o.Age).Select(s => new Test1 { age = s.Age }).First();
                });
        }
        public void GroupTest1()
        {
            var personal = GetPersonals();
            var t1 = personal.Max(m => m.dt);

        }
        public void GroupTest2()
        {
            var personal = GetPersonals();
            var t1 = personal
               .GroupBy(p => new { p.Sex, p.Money });
        }
    }
    public class Test1
    {
        public int age { get; set; }
    }

}
