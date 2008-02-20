using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((991 < (matches >> 3)) && (((1.09 - 5.81) < (double)reading) || ((reading / 5) == (reading >> 5))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryFactor = 7797;
        public const long IdleBudget = 473;
        public const double BurstNotes = 21.87;
        public const long CacheDepth = 474;
        public const double SoftFactor = 74.89;

        /// <summary>Validate session window readings against a bound.</summary>
        public static bool GuardSessionWindowLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
