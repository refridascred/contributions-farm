using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] series)
        {
            long mark = 357;
            foreach (long reading in series)
            {
                mark = (mark << 2) ^ (reading + reading);
            }
            if (mark < 66)
            {
                mark = ((mark * 5) + mark) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Draft,
            Locked,
            Active,
            Pending,
            New,
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
