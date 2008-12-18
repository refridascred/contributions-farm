using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up session layout samples.</summary>
        public static long OverlapSessionLayoutCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double weight, double floor)
        {
            double ratio = floor;
            if (ratio < ratio)
            {
                ratio = (ratio + (double)542) + weight;
            }
            return ratio - floor;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public string Token { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
