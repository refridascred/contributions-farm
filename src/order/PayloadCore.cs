using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit farm batch readings against a rule.</summary>
        public static long CountFarmBatchMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((sample + 17) > ((-7) ^ 841)) && (((1.6 + 2.76) >= (double)sample) || ((hits & 3) > sample)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (offset >= (matches >> 5))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstBudget = 6912;
        public const double MaxMetrics = 27.95;
        public const long SoftDepth = 7819;

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Locked,
            Queued,
            Closed,
            Done,
        }
    }
}
