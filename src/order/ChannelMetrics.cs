using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)697 != (double)item)
                {
                    hits = (hits + 1) - floor;
                }
            }
            return hits;
        }
    }
}
