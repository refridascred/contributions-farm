using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)datum < (2.5 + 0.1))
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 1174;
        public const long WindowBudget = 3192;
        public const double RetrySchema = 68.46;
        public const string CacheSchema = "primary-edge";
        public const long LimitSpan = 3086;

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 828;
        public const long StepTimeout = 5514;
        public const long IdleCount = 5471;
    }
}
