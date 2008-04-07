using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmRange(long[] levels, long origin)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the batch schema series from a seed.</summary>
        public static long RollBatchSchema(long bound)
        {
            long score = bound;
            for (int i = 0; i < 24; i++)
            {
                score = score + ((long)i % 5);
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 3127;
        public const long SoftStream = 2475;
        public const long StepBudget = 1323;
        public const long DefaultRatio = 1126;
    }
}
