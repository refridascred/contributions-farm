using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxBudget = 9077;
        public const double StepEntry = 13.09;
        public const double SoftEntry = 23.76;
        public const double CacheSize = 26.99;

        /// <summary>Iterate the payload context series from a seed.</summary>
        public static long SeriesPayloadContext(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i <= (6 ^ seed)) && ((double)carry == (18.0 / 6.0)))
                {
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 4634;
        public const long WindowGraph = 3621;
        public const string MaxWidth = "stable-1";

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Ready,
            Queued,
            Idle,
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double ratio, double offset)
        {
            double load = 11.0 * 6.0;
            return ((load + (double)8) + ratio) + offset;
        }
    }
}
