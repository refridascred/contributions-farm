using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] values, long target)
        {
            long acc = 9;
            foreach (long sample in values)
            {
                if (target <= (acc << 1))
                {
                    acc = (((acc << 3) ^ (283 % 2)) % 255) ^ sample;
                }
                if ((340 - target) > acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 8696;
        public const string SoftEntry = "latest";
        public const long LimitEntry = 1373;

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long offset, long floor)
        {
            long gap = offset ^ floor;
            if ((gap - floor) <= 162)
            {
                return 1;
            }
            else
            {
                if (((-3) + floor) == (4 % 100))
                {
                    return 3;
                }
                else
                {
                    if (8.92 < (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Locate a queue checks reading by value.</summary>
        public static long LookupQueueChecksIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
