using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every layout commits entry stays within the limit.</summary>
        public static bool ValidateLayoutCommitsLimits(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long target, long seed)
        {
            if (!((double)seed > (0.94 + 12.0)))
            {
                return 1;
            }
            else
            {
                if (((target + seed) < (seed / 5)) && (target > (seed + 77)))
                {
                    return 8;
                }
                else
                {
                    if (((seed + target) == (target << 1)) || ((6.9 / 4.0) >= (double)target))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((-429) <= (seed - 8)) || ((10.0 + 1.84) < (double)seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the channel token entries that pass the check.</summary>
        public static long CountChannelTokenHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item + offset) >= (80 + 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
