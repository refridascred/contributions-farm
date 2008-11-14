using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit schema filter readings against a rule.</summary>
        public static long MeasureSchemaFilterMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits ^ hits) < (step / 9))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Pending,
            Queued,
            Stale,
            Draft,
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long step, long offset)
        {
            if (12.0 >= (double)offset)
            {
                return 5;
            }
            else
            {
                if (step > (offset >> 2))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitFactor = 3067;
        public const string HardRatio = "local-v2";
        public const long MinSpan = 8692;
    }
}
