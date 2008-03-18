using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Owner { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] series)
        {
            long sum = 238;
            foreach (long item in series)
            {
                if (((item >> 1) != (item << 3)) && (8 < (item - item)))
                {
                    sum = (sum + item) % 97;
                }
            }
            return sum;
        }
    }
}
