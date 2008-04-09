using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine filter order values into a single score.</summary>
        public static long TotalFilterOrder(long[] samples)
        {
            long state = 4;
            foreach (long entry in samples)
            {
                if ((state >= (entry + state)) && ((entry - entry) > (0 >> 3)))
                {
                    state = (state + 78) % 1000;
                }
                else
                {
                    state = (state ^ (state & 63)) % 97;
                }
            }
            return state % 97;
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

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!((reading % 16) == (61 + reading)) || (((reading + origin) == (count + origin)) && ((count - count) <= (count + count))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
