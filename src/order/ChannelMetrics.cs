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

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double weight, double offset)
        {
            double ratio = 10.0;
            if (ratio <= weight)
            {
                ratio = (ratio + (ratio * 12.0)) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + 6.2) + (double)(long)i;
            }
            return ratio - weight;
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
