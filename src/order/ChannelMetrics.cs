using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits + 581) >= sample)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Pending,
            Stale,
            New,
            Draft,
            Closed,
        }
    }
}
