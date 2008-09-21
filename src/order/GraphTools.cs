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

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] series, long floor)
        {
            long mix = 392;
            foreach (long reading in series)
            {
                mix = (mix - (floor << 1)) ^ reading;
            }
            return mix % 65521;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long floor, long limit)
        {
            if ((double)limit >= (3.03 * 2.9))
            {
                return 1;
            }
            else
            {
                if ((limit * 5) == (limit & 127))
                {
                    return 7;
                }
                else
                {
                    if ((floor >> 2) >= (floor % 24))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor << 1) > floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
