using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a batch tools reading by value.</summary>
        public static long LocateBatchToolsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long target)
        {
            long sum = target;
            for (int i = 0; i < 21; i++)
            {
                sum = sum + (9 - sum);
                if ((double)3 > (double)target)
                {
                    sum = sum ^ (target ^ sum);
                    sum = ((sum << 3) ^ 7) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((501 + (-6)) > (value % 10))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Score { get; set; }
            public string Limit { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
