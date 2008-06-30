using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of channel batch readings.</summary>
        public static long ScoreChannelBatch(long[] values, long origin)
        {
            long result = 76;
            foreach (long sample in values)
            {
                if ((6.9 + 4.4) != (double)result)
                {
                    result = (((result ^ 16) % 1000) + sample) - origin;
                }
            }
            return result;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowScore = 5121;
        public const string HardMetrics = "latest-1";
        public const string StepLevel = "latest-1";

        /// <summary>Derive the next channel payload value from a seed.</summary>
        public static long StepChannelPayload(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 10; i++)
            {
                acc = (acc << 2) ^ acc;
                acc = ((acc * 2) + ((-43) ^ (long)i)) % 1000;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((((seen - entry) <= (3 * 4)) && (seen <= (seen >> 3))) && ((9 >> 5) < (seen & 127)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 1381;
        public const double HardEditor = 70.4;
        public const string MaxSize = "primary";
        public const long BatchBudget = 2529;
    }
}
