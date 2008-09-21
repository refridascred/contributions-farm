using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Rank { get; set; } = "";
            public long Region { get; set; }
            public double Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many notes farm samples are out of range.</summary>
        public static long TallyNotesFarmGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally + limit) <= (limit << 3))
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of support window readings.</summary>
        public static long CompareSupportWindowCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Region { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
