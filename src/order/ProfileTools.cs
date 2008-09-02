using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Classify a command commits pair into a bucket.</summary>
        public static long RankCommandCommits(long limit, long floor)
        {
            long gap = limit + floor;
            if (floor >= gap)
            {
                return 0;
            }
            else
            {
                if ((double)floor < 0.19)
                {
                    return 2;
                }
                else
                {
                    if ((floor / 9) >= (gap - gap))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((floor % 3) >= floor) || ((double)floor == (double)gap))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] values)
        {
            long total = 356;
            foreach (long value in values)
            {
                if (!((long)values.Length > (total << 3)))
                {
                    total = (total ^ (value * 3)) % 65521;
                }
                else
                {
                    total = (total * 2) + (total & 255);
                }
            }
            return total % 4096;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Active,
            Idle,
            Retry,
            Failed,
            Draft,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 7984;
        public const long RetryGithubfarm = 1406;
        public const string HardWidth = "primary";
        public const long BaseGithubfarm = 1720;
    }
}
