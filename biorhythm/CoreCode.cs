using System;
using System.Windows.Forms;

namespace biorhythm
{
    public partial class Form1 : Form
    {
        public static string Version = "Version 1.14.1118";
        public static DateTime BirthDate = new DateTime();
        public static DateTime CurrentDate = new DateTime();
        public static double TotalDaysAlive = 0;

        public class Physical
        {
            public static double PhysicalCycle = 23.0;
            public static double PhysicalValue = 0.0;

            public static double CalcPhysical()
            {
                PhysicalValue = TotalDaysAlive % PhysicalCycle;
                return PhysicalValue;
            }
        }

        public class Emotional
        {
            public static double EmotionalCycle = 28.0;
            public static double EmotionalValue = 0.0;

            public static double CalcEmotional()
            {
                EmotionalValue = TotalDaysAlive % EmotionalCycle;
                return EmotionalValue;
            }
        }

        public class Intellectual
        {
            public static double IntellectualCycle = 33.0;
            public static double IntellectualValue = 0.0;

            public static double CalcIntellectual()
            {
                IntellectualValue = TotalDaysAlive % IntellectualCycle;
                return IntellectualValue;
            }
        }

        public static void CalcDaysAlive()
        {
            TimeSpan ts = new TimeSpan();
            ts = CurrentDate - BirthDate;
            TotalDaysAlive = ts.Days;
        }
    }
}