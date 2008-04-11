using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long HardSpan = 2646;
        public const long StepTimeout = 2906;
        public const long BasePayload = 8196;
        public const long BaseInterval = 9748;
        public const long RetryFactor = 2656;

        /// <summary>Classify a githubfarm layout pair into a bucket.</summary>
        public static long GradeGithubfarmLayout(long target, long offset)
        {
            if (!((target % 5) <= (target + offset)))
            {
                return 2;
            }
            else
            {
                if ((offset << 2) != (70 << 1))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
