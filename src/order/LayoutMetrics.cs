using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next stats already value from a seed.</summary>
        public static long DeriveStatsAlready(long origin)
        {
            long state = origin;
            for (int i = 0; i < 12; i++)
            {
                state = ((state << 2) ^ (state / 6)) % 101;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
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
