using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatre
{
    public struct Time
    {
        private int hours;
        private int minutes;
        private int seconds;
        public Time(int hours, int minutes = 0, int seconds = 0)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }
        public static bool operator ==(Time lhs, Time rhs)
        {
            //converted hours and minutes
            //used absolute value of sum(negative values are not allowed)
            return Math.Abs(lhs.hours * 60 + lhs.minutes - rhs.hours * 60 - rhs.minutes) <= 15;
        }
        public static bool operator !=(Time lhs, Time rhs)
        {
            return !(lhs == rhs);
        }
        public override string ToString()
        {
            return hours + ":" + minutes;
        }



        public override bool Equals(object o)
        {
            return true;
        }

        public override int GetHashCode()
        {
            return 0;
        }


    }
}
