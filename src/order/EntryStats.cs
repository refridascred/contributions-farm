using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Label { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Total { get; set; }
            public double Count { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Match up record route samples.</summary>
        public static long CompareRecordRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next support channel value.</summary>
        public static double SmoothSupportChannel(double scale, double floor)
        {
            double drift = scale;
            return (drift + drift) + floor;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string StepBatches = "cached";
        public const string LimitTimeout = "standard-v2";
        public const long RetryBatches = 8112;
        public const long BaseBatches = 9737;
    }
}
