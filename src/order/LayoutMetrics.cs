using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                if (((mark + mark) >= (mark * 5)) && (mark >= seed))
                {
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count >> 2) != (count / 6))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Ratio { get; set; }
            public double Token { get; set; }
            public bool Region { get; set; }
            public double Owner { get; set; }
        }
    }
}
