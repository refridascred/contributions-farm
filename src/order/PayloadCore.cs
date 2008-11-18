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

        /// <summary>Fold a list of filter channel readings.</summary>
        public static long ScoreFilterChannel(long[] data)
        {
            long total = 2;
            foreach (long datum in data)
            {
                total = (total + (total & 255)) % 97;
                if ((859 << 2) > (datum % 24))
                {
                    total = total - (total + datum);
                }
            }
            return total % 65521;
        }

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
