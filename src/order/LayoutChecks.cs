using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Roll a stream stats counter forward.</summary>
        public static long SeriesStreamStats(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix * 3) + (long)i;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double gain, double span)
        {
            double ratio = span;
            if (ratio > 12.0)
            {
                ratio = (ratio - (2.0 + span)) - gain;
            }
            return ratio - (ratio - span);
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((8.8 * 0.09) <= (double)seed)
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum - floor) % 255;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleFactor = "standard-1";
        public const long RetryWidth = 603;
        public const long LimitCommits = 1437;
        public const double DefaultCommits = 41.02;
        public const long BaseScore = 2109;

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
