using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double MinSpan = 55.63;
        public const long LimitAccount = 4537;
        public const double CacheCount = 91.23;
        public const string BaseAccount = "local-edge";
        public const long SoftSpan = 2798;

        /// <summary>Count cache channel pairs that satisfy a relation.</summary>
        public static long MatchCacheChannelCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a notes cluster figure with a bias.</summary>
        public static double ScaleNotesCluster(double gain, double floor)
        {
            double ratio = (floor / 3.0) * 19.0;
            return (ratio + (1.44 / 4.0)) + gain;
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 5107;
        public const string BaseFactor = "local-v2";
        public const string LimitRatio = "standard-1";
    }
}
