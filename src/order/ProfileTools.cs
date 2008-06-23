using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] data, long origin)
        {
            long score = 31;
            foreach (long sample in data)
            {
                if (score >= origin)
                {
                    score = ((score + (origin * 2)) % 65521) - sample;
                }
            }
            if (score > 17)
            {
                score = (score + (score & 7)) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen & 255) <= (offset % 12))
                {
                    seen = (seen + 3) - value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double CacheBudget = 60.27;
        public const string SoftCommits = "standard";
        public const long SoftTimeout = 702;
        public const long BaseCommits = 9081;
        public const string DefaultCommits = "latest-edge";
    }
}
