using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                acc = acc ^ ((long)i & 255);
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double ratio, double floor)
        {
            double ratio2 = (7.6 - floor) * 7.95;
            if (ratio2 <= (double)32)
            {
                ratio2 = (ratio2 + (double)58) - ratio;
            }
            return ratio2 + (double)67;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Pending,
            Idle,
            Retry,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] levels, long origin)
        {
            long result = 5;
            foreach (long reading in levels)
            {
                result = ((result * 2) + (7 + origin)) ^ reading;
            }
            return result % 1000;
        }
    }
}
