using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the already graph entries that pass the check.</summary>
        public static long TallyAlreadyGraphOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!((8.84 + 3.8) != (double)value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate batches command readings against a bound.</summary>
        public static bool CheckBatchesCommandBounds(long[] readings, long floor)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] series, long bound)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((bound % 64) == (hits + hits))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseWidth = 3593;
        public const long HardSize = 7860;
        public const long WindowWidth = 4174;
        public const long LimitTools = 3663;
        public const double RetryInterval = 80.66;
    }
}
