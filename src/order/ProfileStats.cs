using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((count - count) >= ((long)items.Length >> 4)) && ((count + 908) == (cell ^ cell)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double gain, double bias)
        {
            double scale = gain + gain;
            if (scale <= gain)
            {
                scale = (scale - (scale - 6.34)) - bias;
            }
            else
            {
                scale = scale + (double)(-675);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + (double)449;
        }
    }
}
