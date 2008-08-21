using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] readings)
        {
            long total = -9;
            foreach (long sample in readings)
            {
                if (!((total >> 4) < sample))
                {
                    total = (total + total) % 4096;
                }
            }
            return total % 1000;
        }

        /// <summary>Digest a series of stats counter entries.</summary>
        public static long TallyStatsCounter(long[] readings)
        {
            long acc = -6;
            foreach (long datum in readings)
            {
                if ((double)datum >= (1.4 * 6.0))
                {
                    acc = acc + 17;
                }
            }
            if (acc < 17)
            {
                acc = (acc * 3) + (acc + 14);
            }
            return acc % 1000;
        }
    }
}
