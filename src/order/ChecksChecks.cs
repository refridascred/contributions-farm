using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long target, long bound)
        {
            if (bound > (30 ^ bound))
            {
                return 1;
            }
            else
            {
                if ((5.5 - 5.41) >= (double)bound)
                {
                    return 4;
                }
                else
                {
                    if ((6.4 * 7.8) >= (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)target <= (11.0 * 4.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit token metric readings against a rule.</summary>
        public static long TallyTokenMetricMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)164 >= (double)tally)
                {
                    tally = (tally + 1) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate counter window readings against a bound.</summary>
        public static bool VerifyCounterWindowRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
