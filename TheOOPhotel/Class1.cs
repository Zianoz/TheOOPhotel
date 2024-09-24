using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOOPhotel
{
    class hotelbooking
    {
        public String name;
        public int age;
        public int day;
        public DateTime startDate;
        public DateTime endDate;
        public hotelbooking(String name, int age, int day, DateTime startDate, DateTime endDate)
        {
            this.name = name;
            this.age = age;
            this.day = day;
            this.startDate = startDate;
            this.endDate = endDate;

        }

    }
}
