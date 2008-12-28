using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleDepth = 960;
        public const string BurstFactor = "fallback-1";
        public const string BaseFactor = "staging-v2";
        public const double HardTimeout = 23.13;

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] items)
        {
            long result = -1;
            foreach (long value in items)
            {
                if ((value + value) <= result)
                {
                    result = (result << 2) ^ (result / 5);
                }
                else
                {
                    result = ((result << 3) ^ (result + result)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinSchema = 66.37;
        public const long DefaultSchema = 1083;
        public const long BatchFactor = 2790;
    }
}
