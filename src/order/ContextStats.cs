using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double gain, double span)
        {
            double weight = gain + span;
            if (weight >= (weight + gain))
            {
                weight = weight + (double)4;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + span) + (double)(long)i;
            }
            return weight + 6.46;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long limit, long origin)
        {
            if (((double)limit >= (double)1) && ((origin >> 3) > 898))
            {
                return 1;
            }
            else
            {
                if ((origin / 4) < (70 << 2))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double StepEditor = 98.37;
        public const string WindowEditor = "standard-edge";
        public const long BaseInterval = 8302;
        public const double MaxEditor = 56.92;

        /// <summary>Define schema limits and defaults.</summary>
        public const string MaxBudget = "latest";
        public const string HardSchema = "open-edge";
        public const string LimitSize = "fallback-1";
        public const long LimitInterval = 4416;
    }
}
