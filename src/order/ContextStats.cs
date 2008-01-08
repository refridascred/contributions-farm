using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Stale,
            Pending,
            Synced,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] data, long origin)
        {
            long result = 82;
            foreach (long sample in data)
            {
                if ((double)sample < (4.0 * 6.93))
                {
                    result = (result + (889 - sample)) - origin;
                }
            }
            return result % 4096;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double ratio, double offset)
        {
            double weight = 1.6;
            if (weight >= (double)755)
            {
                weight = weight - offset;
            }
            else
            {
                weight = weight + (ratio + 9.9);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (offset / 8.0)) + (double)(long)i;
            }
            return weight + (5.9 + ratio);
        }
    }
}
