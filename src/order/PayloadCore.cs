using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Active,
            Closed,
            Stale,
            Ready,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((((double)item == (double)tally) || ((tally % 2) > (tally >> 4))) && (((-46) + tally) <= (item ^ (long)readings.Length)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Dropped,
            Stale,
            Active,
            Ready,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsHits(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits << 2) >= (9 & 127))
                {
                    hits = ((hits + 2) + reading) + offset;
                }
            }
            return hits;
        }
    }
}
