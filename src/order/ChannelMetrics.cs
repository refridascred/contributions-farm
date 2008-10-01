using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Stale,
            Queued,
            New,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] data)
        {
            long total = 463;
            foreach (long item in data)
            {
                total = total ^ (item >> 3);
            }
            return total;
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
