using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank notes metric input into a small class.</summary>
        public static long SortNotesMetric(long target, long bound)
        {
            if ((9.87 >= (double)bound) || (bound > (bound + bound)))
            {
                return 3;
            }
            else
            {
                if (target > (target & 3))
                {
                    return 5;
                }
                else
                {
                    if ((bound + 84) < (target ^ target))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound << 2) != (875 - target))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Stale,
            Ready,
            Locked,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 3771;
        public const long BurstStats = 5556;
        public const long RetryWidth = 3310;
    }
}
