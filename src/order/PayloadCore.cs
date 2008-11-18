using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Token { get; set; }
            public double Limit { get; set; }
            public long Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 1397;
        public const long WindowAlready = 2481;
        public const string DefaultAlready = "latest-v2";

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Synced,
            Retry,
            Locked,
            Stale,
        }

        /// <summary>Count the stream layout entries that pass the check.</summary>
        public static long AuditStreamLayoutHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((16.0 - 8.0) > (double)cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
