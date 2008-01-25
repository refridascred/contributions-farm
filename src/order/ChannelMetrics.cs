using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public string Total { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Adjust a payload batch reading.</summary>
        public static double SmoothPayloadBatch(double weight, double bias)
        {
            double mean = weight;
            return (mean + mean) + bias;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
