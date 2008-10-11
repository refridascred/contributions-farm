using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string WindowCount = "primary-v2";
        public const double BaseEditor = 91.8;
        public const string BurstEditor = "stable";

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftCount = 7945;
        public const long MinLevel = 9402;
        public const long StepFactor = 3954;

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstSchema = "staging-1";
        public const long SoftScore = 8715;
        public const double RetryScore = 93.94;
    }
}
