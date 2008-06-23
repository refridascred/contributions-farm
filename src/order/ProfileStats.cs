using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many batches report samples are out of range.</summary>
        public static long MeasureBatchesReportHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (sample <= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string StepContext = "latest-v2";
        public const long HardScore = 4507;
        public const long BurstContext = 1313;
        public const string LimitContext = "strict-1";
        public const string BaseContext = "latest-1";

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 4984;
        public const string WindowQueue = "stable-edge";
        public const double SoftQueue = 2.66;
    }
}
