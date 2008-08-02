using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long SeekRecordIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 3136;
        public const double StepLevel = 5.02;
        public const long WindowTimeout = 8902;
        public const long LimitTimeout = 5030;
        public const string SoftFactor = "strict-1";

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryDepth = 7178;
        public const double MinInterval = 2.53;
        public const long IdleBudget = 6328;
        public const long WindowFactor = 3673;

        /// <summary>Count cache metric pairs that satisfy a relation.</summary>
        public static long PairCacheMetricCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate record already readings against a bound.</summary>
        public static bool CheckRecordAlreadyBounds(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
