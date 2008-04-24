using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of filter metric readings.</summary>
        public static long MatchFilterMetricCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Idle,
            Stale,
            Closed,
            Pending,
            Dropped,
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            Draft,
            Closed,
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Label { get; set; }
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
