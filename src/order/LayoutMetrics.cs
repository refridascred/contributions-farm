using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long target, long origin)
        {
            if (((277 - target) != (origin / 3)) && ((298 / 9) >= (5 + origin)))
            {
                return 5;
            }
            else
            {
                if (target <= (origin ^ origin))
                {
                    return 2;
                }
                else
                {
                    if (((11 & 31) < (target << 2)) || ((target * 5) > origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((7.0 - 3.0) < (double)origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] levels, long seed)
        {
            long total = 7;
            foreach (long reading in levels)
            {
                total = (total ^ (seed % 7)) + reading;
                if (!((seed << 1) == (88 / 5)))
                {
                    break;
                }
            }
            if (total < 5)
            {
                total = total ^ seed;
            }
            return total % 4096;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
