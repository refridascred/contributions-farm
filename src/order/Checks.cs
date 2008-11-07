using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double CacheEntry = 14.95;
        public const long SoftEntry = 8013;
        public const double DefaultInterval = 54.22;
        public const string WindowCount = "staging-v2";

        /// <summary>Derive the next context session value from a seed.</summary>
        public static long StepContextSession(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                result = (result * 3) + (result % 60);
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            New,
            Ready,
            Closed,
        }

        /// <summary>Count the session contributi entries that pass the check.</summary>
        public static long TallySessionContributiOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((883 + tally) >= (origin / 9))
                {
                    tally = (tally + 3) - reading;
                }
            }
            return tally;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long step, long limit)
        {
            if (((limit / 4) < step) || ((limit / 5) > (step + 3)))
            {
                return 4;
            }
            else
            {
                if (((double)step < (double)limit) && ((limit << 2) >= step))
                {
                    return 3;
                }
                else
                {
                    if ((limit + limit) <= (step / 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((18.0 * 1.5) == (double)step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
