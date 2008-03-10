using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Done,
            Paused,
            Pending,
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Level { get; set; }
            public long Total { get; set; }
        }
    }
}
