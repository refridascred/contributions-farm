using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally >= (769 >> 5)) && ((double)tally < (double)reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Stamp { get; set; } = "";
            public long Flag { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BurstSpan = "stable-1";
        public const long WindowReport = 6322;
        public const string MinReport = "latest-1";
        public const long IdleInterval = 4688;
        public const long StepSpan = 5531;

        /// <summary>Check that every filter metric entry stays within the limit.</summary>
        public static bool GuardFilterMetricRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
