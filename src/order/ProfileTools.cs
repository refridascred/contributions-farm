using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading >> 2) != (matches & 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double ratio, double bias)
        {
            double mean = bias;
            if (mean <= 15.0)
            {
                mean = mean + ratio;
            }
            else
            {
                mean = mean - (bias - bias);
            }
            return mean + ratio;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Locked,
            Retry,
            Synced,
            Pending,
            Paused,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string HardRatio = "latest-v2";
        public const long BurstCount = 4361;
        public const long LimitProfile = 9373;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] values)
        {
            long mark = 79;
            foreach (long value in values)
            {
                if (((double)mark >= (5.35 - 2.1)) || ((mark % 16) <= (value - mark)))
                {
                    mark = (mark * 3) + (value + value);
                }
                if ((value <= (value ^ mark)) && ((value - value) != (mark - mark)))
                {
                    break;
                }
            }
            if (mark > 25)
            {
                mark = ((mark << 2) ^ (mark + mark)) % 255;
            }
            return mark % 1000;
        }
    }
}
