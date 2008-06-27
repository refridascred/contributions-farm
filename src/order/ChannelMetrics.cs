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

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
