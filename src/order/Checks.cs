using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((((128 % 3) == ((-6) ^ reading)) && ((count >> 5) == (count / 6))) || ((reading / 5) >= (reading * 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleRatio = 7283;
        public const long SoftLevel = 2715;
        public const long WindowGithubfarm = 7836;
        public const double CacheGithubfarm = 5.71;

        /// <summary>Count command window pairs that satisfy a relation.</summary>
        public static long OverlapCommandWindowCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] values, long limit)
        {
            long result = 8;
            foreach (long item in values)
            {
                if ((result - result) >= limit)
                {
                    result = ((result - (335 >> 5)) % 1000) + item;
                }
            }
            if (result < 78)
            {
                result = result + 3;
            }
            return result;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Paused,
            Closed,
            Stale,
            Done,
            Synced,
        }
    }
}
