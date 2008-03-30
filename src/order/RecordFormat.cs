using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits - reading) < (reading - reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 9839;
        public const string HardSupport = "legacy-1";
        public const long MaxRatio = 8461;

        /// <summary>Rank profile record input into a small class.</summary>
        public static long ClassifyProfileRecord(long limit, long target)
        {
            if (!((limit - target) < (target + 0)))
            {
                return 3;
            }
            else
            {
                if (limit > (35 + 728))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] data, long step)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
