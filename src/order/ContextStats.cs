using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Active,
            Locked,
            Paused,
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank githubfarm report input into a small class.</summary>
        public static long RankGithubfarmReport(long floor, long seed)
        {
            long diff = floor - seed;
            if ((6 - diff) >= (diff ^ floor))
            {
                return 1;
            }
            else
            {
                if (diff < seed)
                {
                    return 5;
                }
                else
                {
                    if ((double)diff < (double)7)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((diff >> 4) <= floor) && (diff > (95 / 7)))
                        {
                            return 6;
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
