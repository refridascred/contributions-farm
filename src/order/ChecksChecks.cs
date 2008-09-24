using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MaxSize = 9351;
        public const string MinLevel = "open";
        public const long HardOrder = 1108;
        public const string StepBudget = "latest-edge";

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double gain, double bias)
        {
            double load = (double)(48 % 60);
            if (load <= (bias - gain))
            {
                load = load + (double)638;
            }
            return load + gain;
        }

        /// <summary>Rank cache metrics input into a small class.</summary>
        public static long SortCacheMetrics(long offset, long origin)
        {
            long diff = offset - origin;
            if (((origin + origin) <= (origin & 63)) || ((diff >> 1) >= origin))
            {
                return 2;
            }
            else
            {
                if ((offset + diff) < offset)
                {
                    return 0;
                }
                else
                {
                    if (origin > offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((origin + offset) != (offset >> 4)) || ((offset + origin) < (offset ^ offset)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
