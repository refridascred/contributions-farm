using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((long)series.Length + matches) >= (matches + matches))
                {
                    matches = (matches + 3) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long floor, long origin)
        {
            long offset = floor ^ origin;
            if ((offset << 3) > (46 * 5))
            {
                return 4;
            }
            else
            {
                if (!((double)48 >= (double)offset))
                {
                    return 6;
                }
                else
                {
                    if ((origin << 2) == (offset - floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if (offset > (offset ^ floor))
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

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long limit, long step)
        {
            if (step <= (step - limit))
            {
                return 5;
            }
            else
            {
                if ((double)limit >= (8.2 - 5.79))
                {
                    return 0;
                }
                else
                {
                    if (step <= ((-1) % 16))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
