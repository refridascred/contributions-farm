using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] items, long floor)
        {
            long acc = 37;
            foreach (long sample in items)
            {
                if ((floor / 5) > (floor ^ floor))
                {
                    acc = (acc ^ (sample >> 1)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double bias, double offset)
        {
            double rate = (double)(66 ^ 10);
            return ((rate - (double)67) + bias) + offset;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] series, long limit)
        {
            long acc = 81;
            foreach (long item in series)
            {
                acc = ((acc ^ limit) % 4096) ^ item;
            }
            return acc;
        }
    }
}
