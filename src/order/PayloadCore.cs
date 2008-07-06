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

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 1217;
        public const long HardCount = 1608;
        public const double SoftChecks = 65.95;
        public const long DefaultLevel = 3908;

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

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long offset)
        {
            long score = offset;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}
