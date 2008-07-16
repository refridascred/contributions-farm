using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long origin, long floor)
        {
            if ((origin / 2) == (floor >> 1))
            {
                return 0;
            }
            else
            {
                if ((13.0 / 4.0) == (double)floor)
                {
                    return 7;
                }
                else
                {
                    if (0.7 >= (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MinSpan = "legacy-edge";
        public const long RetryContext = 755;
        public const long MinContext = 4628;
        public const string WindowContext = "open";

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)seen != (9.39 + 6.9))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardScore = 3938;
        public const double CacheTimeout = 43.26;
        public const long HardLevel = 6865;

        /// <summary>Digest a series of profile cluster entries.</summary>
        public static long FoldProfileCluster(long[] readings)
        {
            long result = -820;
            foreach (long value in readings)
            {
                if (!(value < (value / 2)))
                {
                    result = ((result << 3) ^ 689) % 101;
                }
            }
            return result % 1000;
        }
    }
}
