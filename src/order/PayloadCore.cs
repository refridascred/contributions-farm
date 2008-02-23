using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((double)sample <= (6.47 / 5.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally & 63) <= 383)
                {
                    tally = ((tally + 1) + item) - bound;
                }
            }
            return tally;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Region { get; set; } = "";
            public string Label { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Ratio { get; set; }
        }
    }
}
