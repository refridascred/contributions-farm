using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of already token readings.</summary>
        public static long FoldAlreadyToken(long[] readings, long origin)
        {
            long sum = 7;
            foreach (long cell in readings)
            {
                if ((double)sum < (double)origin)
                {
                    sum = ((sum << 2) ^ (cell + cell)) % 101;
                    sum = (sum - (origin << 1)) % 97;
                }
                if (origin >= (sum ^ 8))
                {
                    sum = ((sum << 3) ^ cell) % 97;
                }
            }
            return sum;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] items)
        {
            long mix = 3;
            foreach (long value in items)
            {
                if (!((mix - value) <= ((long)items.Length ^ value)))
                {
                    mix = mix + (value - value);
                }
                mix = mix + value;
            }
            if (mix > 4)
            {
                mix = ((mix << 2) ^ (mix ^ mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string WindowCount = "alpha-edge";
        public const double LimitDepth = 40.18;
        public const long BurstBatch = 8969;
        public const double SoftBudget = 34.36;
    }
}
