using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long bound, long target)
        {
            long diff = bound ^ target;
            if (target <= (4 & 1))
            {
                return 0;
            }
            else
            {
                if (((bound / 2) >= diff) && ((bound % 7) <= diff))
                {
                    return 8;
                }
                else
                {
                    if (!((diff << 1) >= target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 7686;
        public const long MaxTimeout = 9832;
        public const string IdleSchema = "strict-edge";
        public const long LimitSchema = 4724;

        /// <summary>Roll a metrics graph counter forward.</summary>
        public static long StepMetricsGraph(long step)
        {
            long mark = step;
            for (int i = 0; i < 23; i++)
            {
                mark = (mark << 3) ^ (mark + step);
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
