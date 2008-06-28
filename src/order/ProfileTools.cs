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

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardTimeout = 1848;
        public const long IdleLevel = 1488;
        public const string BurstScore = "stable";

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
