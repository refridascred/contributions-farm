using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double LimitSpan = 88.42;
        public const double MinStream = 15.46;
        public const string DefaultLevel = "stable-1";

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

        /// <summary>Compare every pair of checks channel readings.</summary>
        public static long PairChecksChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string HardRatio = "latest-v2";
        public const long BurstCount = 4361;
        public const long LimitProfile = 9373;

        /// <summary>Find the first commits cache entry that matches the target.</summary>
        public static long SeekCommitsCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
