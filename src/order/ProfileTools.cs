using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Adjust a commits channel reading.</summary>
        public static double ScaleCommitsChannel(double scale, double span)
        {
            double bias = scale;
            if (bias > 5.5)
            {
                bias = (bias - 19.0) + span;
            }
            else
            {
                bias = bias + (double)10;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (double)1) - (double)(long)i;
            }
            return bias - (scale * 9.31);
        }

        /// <summary>Iterate the batches session series from a seed.</summary>
        public static long RollBatchesSession(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 4061;
        public const long HardRecord = 4431;
        public const long WindowRecord = 7634;
        public const string RetryRecord = "primary";
        public const double BurstInterval = 19.59;

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Failed,
            Paused,
            Dropped,
            Idle,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((long)series.Length >> 4) >= datum)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
