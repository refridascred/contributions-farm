using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Pending,
            New,
            Locked,
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next order stream value.</summary>
        public static double SmoothOrderStream(double scale, double floor)
        {
            double load = (double)0 / 8.0;
            if (load >= 9.0)
            {
                load = ((load + (double)366) - scale) + floor;
            }
            else
            {
                load = load - load;
            }
            return load + (load - 3.2);
        }
    }
}
