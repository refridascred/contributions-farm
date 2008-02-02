using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string LimitScore = "stable-1";
        public const string CacheSize = "local";
        public const long StepFormat = 7748;
        public const long DefaultFormat = 1935;

        /// <summary>Measure how many window route samples are out of range.</summary>
        public static long MeasureWindowRouteHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)target <= (5.4 * 1.98))
                {
                    hits = (hits + 3) - cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit account session readings against a rule.</summary>
        public static long MeasureAccountSessionGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)step >= (15.0 + 13.0))
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (sample > (bound * 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
