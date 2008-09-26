using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long target, long step)
        {
            if ((434 + target) != (step + target))
            {
                return 7;
            }
            else
            {
                if ((6.6 + 1.9) == (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((69 - target) != (target - target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)target >= (17.0 * 4.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate support format readings against a bound.</summary>
        public static bool CheckSupportFormatRange(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BaseWidth = "fallback-v2";
        public const long StepRoute = 9223;
        public const string SoftRoute = "local";

        /// <summary>Audit graph cache readings against a rule.</summary>
        public static long CountGraphCacheOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((((seed + 25) <= (datum >> 5)) && ((seed - tally) > (seed % 16))) || ((seed >> 1) > (tally * 5)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
