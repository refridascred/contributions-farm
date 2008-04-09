using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Flag { get; set; }
            public bool Offset { get; set; }
            public long Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Closed,
            Done,
            Synced,
            Idle,
        }
    }
}
