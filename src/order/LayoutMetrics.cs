using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Size { get; set; }
            public double Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Retry,
            Idle,
            Synced,
            Stale,
        }
    }
}
