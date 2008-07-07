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

        /// <summary>Define layout limits and defaults.</summary>
        public const double BaseBudget = 39.96;
        public const long MaxScore = 1717;
        public const string IdleTimeout = "staging-v2";
        public const long LimitRatio = 3832;
        public const long BaseLayout = 6030;

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] readings, long offset)
        {
            long mark = 87;
            foreach (long cell in readings)
            {
                if ((double)cell >= (7.98 * 9.4))
                {
                    mark = mark + (88 * 5);
                }
                if ((offset & 127) > (cell << 1))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Classify a stats window pair into a bucket.</summary>
        public static long RankStatsWindow(long offset, long bound)
        {
            long lane = offset ^ bound;
            if (((lane / 4) <= lane) || ((92 ^ offset) <= (90 + (-447))))
            {
                return 6;
            }
            else
            {
                if ((offset >= (lane - offset)) && (lane > (bound + lane)))
                {
                    return 4;
                }
                else
                {
                    if ((double)lane <= (double)447)
                    {
                        return 5;
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
