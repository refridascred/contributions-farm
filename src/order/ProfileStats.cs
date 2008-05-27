using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultStats = 34.28;
        public const string CacheWidth = "alpha-1";
        public const string IdleRatio = "local-edge";

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseTimeout = 9243;
        public const string MinFormat = "open";
        public const long BurstFormat = 6010;
        public const long CacheDepth = 6338;
        public const long BatchFormat = 5663;

        /// <summary>Locate a command githubfarm reading by value.</summary>
        public static long SeekCommandGithubfarmIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
