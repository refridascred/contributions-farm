using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((item * 5) <= count) && (((offset + (-8)) != (0 + offset)) || ((item - 6) == (count + offset))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell * 5) <= origin)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public string Offset { get; set; } = "";
            public bool Limit { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
