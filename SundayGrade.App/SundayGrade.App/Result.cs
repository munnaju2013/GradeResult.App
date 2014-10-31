using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SundayGrade.App
{
    class Result
    {
        public double Physics { get; set; }
        public double Chemistry { get; set; }
        public double Math { get; set; }

        public Result(double physics, double chemistry, double math) : this (physics,chemistry)
        {
            
            Math = math;
        }

        public Result(double physics, double chemistry) : this()
        {
            Physics = physics;
            Chemistry = chemistry;
        }

        public Result()
        {
            
        }

        public double GetAverage()
        {
            return (Physics + Chemistry + Math)/3 ;
        }

        public string GetGradeLetter()
        {
            if (GetAverage() >= 80)
                return "A+";
            if (GetAverage() < 80 && GetAverage() >= 70)
                return "A";
            if (GetAverage() < 70 && GetAverage() >= 60)
                return "B";
            if (GetAverage() < 60 && GetAverage() >= 50)
                return "C";
            if (GetAverage() < 50 && GetAverage() >= 40)
                return "D";
            return "Fail";

        }

    }
}
