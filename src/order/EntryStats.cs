using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Label { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string DefaultCount = "cached-edge";
        public const long BatchReport = 7550;
        public const string LimitReport = "cached-1";
        public const long MinReport = 6936;

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 > 14.0)
            {
                weight2 = (weight2 + (14.0 + 16.0)) + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 - (weight2 + 8.2)) + (double)(long)i;
            }
            return weight2 + (double)(-77);
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Count { get; set; }
            public long Region { get; set; }
        }
    }
}
