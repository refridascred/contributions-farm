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

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
