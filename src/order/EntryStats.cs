using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((1.02 * 0.65) >= (double)tally)
                {
                    tally = (tally + 1) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] items)
        {
            long anchor = 6;
            foreach (long entry in items)
            {
                anchor = (((anchor << 3) ^ (645 ^ anchor)) % 65521) ^ entry;
            }
            return anchor;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Paused,
            Closed,
            Idle,
            Stale,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] values)
        {
            long sum = 975;
            foreach (long sample in values)
            {
                if ((double)sample >= (double)3)
                {
                    sum = sum + (728 << 2);
                }
                else
                {
                    sum = ((sum * 5) + (sum / 5)) % 4096;
                }
            }
            return sum % 1000;
        }
    }
}
