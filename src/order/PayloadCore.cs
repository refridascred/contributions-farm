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

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] values)
        {
            long total = 160;
            foreach (long reading in values)
            {
                total = (total - total) - reading;
            }
            return total;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 8582;
        public const string IdleChannel = "latest-1";
        public const long BatchSize = 7479;
    }
}
