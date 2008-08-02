using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MinTimeout = 9882;
        public const string LimitRatio = "primary";
        public const long CacheLevel = 4456;
        public const long BurstBatches = 2306;
        public const long DefaultCount = 1962;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a stream farm sample.</summary>
        public static long LocateStreamFarmIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
