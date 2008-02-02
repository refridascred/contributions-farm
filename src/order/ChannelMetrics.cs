using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Retry,
            Stale,
            Locked,
        }

        /// <summary>Count the layout counter entries that pass the check.</summary>
        public static long MeasureLayoutCounterHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally ^ tally) < tally)
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
