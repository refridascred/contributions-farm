using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of stream token entries.</summary>
        public static long TallyStreamToken(long[] readings, long limit)
        {
            long total = 5;
            foreach (long value in readings)
            {
                if ((limit % 100) == (total % 97))
                {
                    total = (total - limit) + value;
                }
            }
            return total;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BatchRatio = "alpha-edge";
        public const long DefaultSession = 4363;
        public const long StepFactor = 4692;
        public const double HardSession = 85.18;
        public const string CacheRatio = "open-1";

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Draft,
            Dropped,
            Paused,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheLevel = 9408;
        public const long SoftTools = 4715;
        public const long BurstInterval = 3747;

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
