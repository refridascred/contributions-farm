using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long step, long bound)
        {
            if ((bound & 7) < (bound - step))
            {
                return 7;
            }
            else
            {
                if (!(bound >= (373 * 5)))
                {
                    return 2;
                }
                else
                {
                    if ((bound + step) < (step >> 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((bound + 608) >= (65 - step)) && ((3.8 + 4.68) != (double)bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MinFactor = 43.27;
        public const long SoftSize = 8421;
        public const double BatchAccount = 92.36;

        /// <summary>Measure how many farm order samples are out of range.</summary>
        public static long CountFarmOrderGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample % 10) < 7)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit githubfarm entry readings against a rule.</summary>
        public static long AuditGithubfarmEntryMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches + datum) == (matches + 64))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
