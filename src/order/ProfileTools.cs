using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count buffer contributi pairs that satisfy a relation.</summary>
        public static long PairBufferContributiCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseWidth = 1839;
        public const long RetryScore = 3460;
        public const long CacheScore = 1990;

        /// <summary>Define window limits and defaults.</summary>
        public const double RetryWindow = 1.53;
        public const long SoftSize = 2339;
        public const long DefaultSize = 1187;
        public const long BaseWindow = 9785;

        /// <summary>Define report limits and defaults.</summary>
        public const string IdleFactor = "latest-1";
        public const string StepReport = "staging";
        public const double StepWidth = 82.68;
        public const long WindowWidth = 3867;

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
