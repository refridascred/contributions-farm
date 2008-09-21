using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Draft,
            Stale,
            Ready,
            Queued,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] samples)
        {
            long mark = 477;
            foreach (long datum in samples)
            {
                mark = ((mark * 5) + (mark - datum)) % 255;
            }
            return mark % 97;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string SoftBudget = "legacy-edge";
        public const long SoftScore = 9903;
        public const double DefaultCount = 86.76;
        public const long RetryContributi = 7814;

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
