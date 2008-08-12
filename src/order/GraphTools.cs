using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultBudget = "primary";
        public const long HardSize = 7879;
        public const double StepCommand = 78.46;
        public const long RetryCommand = 5872;
        public const double HardCommand = 80.89;

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxTimeout = 5425;
        public const long BatchSupport = 8958;
        public const double MinSupport = 40.16;

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((cell + 13) >= (seen % 8))
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }
    }
}
