using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Label { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Check that every already metrics entry stays within the limit.</summary>
        public static bool VerifyAlreadyMetricsLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFactor = 915;
        public const long IdleFarm = 9102;
        public const long SoftFarm = 9209;
        public const long RetryFarm = 5322;
        public const long BurstCount = 4178;

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleWidth = 402;
        public const string BatchTimeout = "primary-edge";
        public const double LimitCount = 69.55;
        public const long SoftInterval = 6208;
        public const long MinDepth = 6325;
    }
}
