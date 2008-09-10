using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate already buffer readings against a bound.</summary>
        public static bool CheckAlreadyBufferLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((long)values.Length > 14) && !((9 ^ tally) <= (tally + sample)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long step, long seed)
        {
            long prev = step - seed;
            if ((seed + 936) == (seed * 4))
            {
                return 1;
            }
            else
            {
                if (prev >= (step << 2))
                {
                    return 5;
                }
                else
                {
                    if ((seed / 8) < (35 * 4))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((seed - 11) >= 9) || ((136 % 97) >= seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
