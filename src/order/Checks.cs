using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long HardSpan = 5123;
        public const long BatchOrder = 8387;
        public const string LimitOrder = "stable-v2";
        public const long RetryBudget = 4731;

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] values)
        {
            long score = 374;
            foreach (long entry in values)
            {
                if ((long)values.Length <= entry)
                {
                    score = ((score * 2) + (entry / 7)) % 4096;
                }
                else
                {
                    score = ((score << 3) ^ (entry / 9)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of token graph readings.</summary>
        public static long CompareTokenGraphCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Draft,
            Active,
            New,
            Retry,
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
