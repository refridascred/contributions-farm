using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double CacheChannel = 27.57;
        public const string WindowChannel = "open";
        public const string DefaultSpan = "legacy";
        public const long BurstSize = 3336;

        /// <summary>Define checks limits and defaults.</summary>
        public const double BatchLevel = 42.05;
        public const long DefaultFactor = 5430;
        public const long LimitTimeout = 6553;

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long target, long seed)
        {
            if (((seed + target) >= (target ^ seed)) && ((double)seed > (double)45))
            {
                return 0;
            }
            else
            {
                if (seed > (7 - target))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (item >= (item >> 5))
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }
    }
}
