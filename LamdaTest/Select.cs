using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LamdaTest
{
    public class Select : Base
    {
        public void SelectTest()
        {
            var personal = GetPersonals();
            var t1 = personal.Select(s =>
            {
                if (s.Age > 30)
                {
                    return s;
                }
                else
                {
                    return null;
                }
            }).ToList();

            var t2 = personal.Where(s =>
            {
                if (s.Age > 30)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }).ToList();
        }
    }
}