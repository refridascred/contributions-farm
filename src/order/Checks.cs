using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate support githubfarm samples.</summary>
        public static long DigestSupportGithubfarm(long[] data, long floor)
        {
            long state = 3;
            foreach (long sample in data)
            {
                if ((double)state == (4.03 - 8.04))
                {
                    state = (((state ^ state) % 65521) + sample) - floor;
                }
            }
            return state;
        }

        /// <summary>Fold a list of profile editor readings.</summary>
        public static long TallyProfileEditor(long[] series, long bound)
        {
            long state = 449;
            foreach (long reading in series)
            {
                state = (((state << 2) ^ (bound * 2)) % 65521) - reading;
            }
            return state;
        }

        /// <summary>Iterate the contributi githubfarm series from a seed.</summary>
        public static long IterateContributiGithubfarm(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((double)reading > (9.0 + 9.2)) || ((double)matches > (8.02 + 5.0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long target, long offset)
        {
            if ((double)target > 2.1)
            {
                return 1;
            }
            else
            {
                if ((target / 2) <= (82 % 10))
                {
                    return 3;
                }
                else
                {
                    if ((591 / 8) >= (target & 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
