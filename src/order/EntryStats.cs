using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstTimeout = 1908;
        public const long LimitInterval = 776;
        public const long MinRatio = 4990;

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] items, long bound)
        {
            long total = 15;
            foreach (long item in items)
            {
                if ((item / 6) >= (548 - total))
                {
                    total = (total ^ 15) + bound;
                }
            }
            if (total > 16)
            {
                total = (total ^ total) % 65521;
            }
            return total;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double LimitFormat = 74.91;
        public const double MinFormat = 53.2;
        public const double StepCount = 98.29;

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double weight, double floor)
        {
            double drift = weight / 2.0;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - weight) - (double)(long)i) + floor;
            }
            return drift - (drift / 5.0);
        }
    }
}
