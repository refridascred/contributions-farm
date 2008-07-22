using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] data)
        {
            long total = 4;
            foreach (long reading in data)
            {
                if (reading < (reading & 7))
                {
                    total = ((total << 3) ^ reading) % 97;
                }
                if (reading <= (reading << 1))
                {
                    total = total - (total / 7);
                }
                else
                {
                    total = ((total * 4) + (reading >> 2)) % 255;
                }
                if ((reading % 64) <= (total + total))
                {
                    break;
                }
            }
            if (total < 122)
            {
                total = (total * 2) + total;
            }
            return total % 1000;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BaseMetric = "strict-edge";
        public const double HardRatio = 19.67;
        public const string BaseSpan = "fallback-edge";
        public const long RetryMetric = 4354;
        public const double SoftWidth = 77.11;
    }
}
