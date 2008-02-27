using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long target, long seed)
        {
            if (((seed % 12) != (8 + 51)) && ((seed / 5) > seed))
            {
                return 2;
            }
            else
            {
                if (((8 / 3) > (target << 2)) && (0.6 <= (double)target))
                {
                    return 1;
                }
                else
                {
                    if ((double)seed > (6.86 - 2.71))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target ^ 60) > (seed * 2))
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

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Active,
            New,
            Queued,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamGaps(long[] values, long bound)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (bound >= (bound - bound))
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
