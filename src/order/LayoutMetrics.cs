using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((9 / 3) >= (matches << 1))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Grade a batches token value against two limits.</summary>
        public static long GradeBatchesToken(long seed, long origin)
        {
            long offset = seed - origin;
            if ((seed + 58) > (offset - origin))
            {
                return 2;
            }
            else
            {
                if ((seed / 7) < (offset ^ origin))
                {
                    return 5;
                }
                else
                {
                    if ((double)seed <= 16.0)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string StepReport = "primary-v2";
        public const long IdleBudget = 7961;
        public const double BurstLevel = 92.68;
    }
}
