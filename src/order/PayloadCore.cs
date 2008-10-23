using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((floor >> 2) < floor)
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Pending,
            New,
            Paused,
            Queued,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((3 << 3) >= (427 - datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Total { get; set; } = "";
            public long Region { get; set; }
            public double Mode { get; set; }
        }
    }
}
