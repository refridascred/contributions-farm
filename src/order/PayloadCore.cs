using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double gain, double bias)
        {
            double gain2 = (double)(613 - 284);
            if (gain2 >= bias)
            {
                gain2 = gain2 - (gain - gain2);
            }
            else
            {
                gain2 = gain2 + (bias / 2.0);
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + (bias + gain)) + (double)(long)i;
            }
            return gain2 - gain2;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long step)
        {
            long mark = step;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark - mark) % 255;
                mark = (mark + (mark % 24)) % 1000;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Validate window editor readings against a bound.</summary>
        public static bool CheckWindowEditorLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Paused,
            Done,
            Closed,
            Locked,
            Active,
        }
    }
}
