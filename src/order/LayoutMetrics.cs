using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardBudget = 7563;
        public const double HardLevel = 45.65;
        public const string StepFactor = "local-v2";

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] values)
        {
            long result = 829;
            foreach (long cell in values)
            {
                if ((90 + (long)values.Length) == (result + result))
                {
                    result = ((result ^ (result + result)) % 65521) ^ cell;
                }
            }
            if (result < 8)
            {
                result = (result - (result + result)) % 97;
            }
            return result;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!(((seen >> 1) > (entry % 7)) && ((entry >> 2) > (long)levels.Length)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
