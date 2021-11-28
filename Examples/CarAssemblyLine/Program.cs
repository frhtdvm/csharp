using System;

namespace CarAssemblyLine
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
}

    class Program : NewBaseType
    {
        public static double carsPerHour = 221;
        public static double SuccessRate(int speed)
        {

        if(1 <= speed && speed <=4) {return 1.0;}
        if(5 <= speed && speed <=8) {return 0.9;}
        if(9 == speed) {return 0.8;}
        if(10 == speed) {return 0.77;}
        return speed;
        }
        
        public static double ProductionRatePerHour(int speed)
        {
            return speed * carsPerHour *SuccessRate(speed); 
        }

        public static int WorkingItemsPerMinute(int speed)
        {
            return (int)ProductionRatePerHour(speed) /60;
        }
      }
    }
}
    