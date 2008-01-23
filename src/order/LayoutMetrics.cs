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

        /// <summary>Define layout limits and defaults.</summary>
        public const string IdleCount = "primary-v2";
        public const long DefaultLayout = 4755;
        public const long StepLayout = 9182;

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 9841;
        public const string IdleCommits = "stable";
        public const long DefaultCommits = 4153;
        public const long IdleScore = 5274;
        public const long BurstBudget = 6529;
    }
}
