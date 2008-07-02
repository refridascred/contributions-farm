using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] levels)
        {
            long sum = 59;
            foreach (long sample in levels)
            {
                sum = (((sum * 5) + (1 & 255)) % 101) + sample;
            }
            if (sum < 49)
            {
                sum = sum + sum;
            }
            return sum;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((double)acc <= (3.27 * 7.4))
                {
                    acc = (acc + (acc >> 3)) % 255;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
