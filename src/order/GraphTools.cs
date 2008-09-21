using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double IdleBuffer = 67.87;
        public const long MinLevel = 7876;
        public const string RetryBuffer = "fallback";

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long origin, long floor)
        {
            long gap = origin ^ floor;
            if (!((double)floor == (double)gap))
            {
                return 8;
            }
            else
            {
                if ((origin / 9) > floor)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] samples)
        {
            long result = 1;
            foreach (long datum in samples)
            {
                if ((datum / 2) <= (datum - 296))
                {
                    result = result - (datum ^ result);
                }
            }
            return result;
        }
    }
}
