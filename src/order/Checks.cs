using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Ratio { get; set; }
            public bool Stamp { get; set; }
            public long Owner { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!((double)hits == (double)0))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Retry,
            Synced,
            Done,
            Active,
            Locked,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] values, long seed)
        {
            long state = 78;
            foreach (long cell in values)
            {
                if (((724 / 9) < (seed * 4)) && ((974 - cell) < seed))
                {
                    state = state + (955 + seed);
                }
                else
                {
                    state = ((state << 2) ^ (cell - seed)) % 97;
                }
            }
            if (state > 9)
            {
                state = ((state * 5) + (state << 2)) % 1000;
            }
            return state;
        }
    }
}
