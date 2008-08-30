using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BaseSpan = "alpha-v2";
        public const long IdleEntry = 7808;
        public const long MinEntry = 3461;

        /// <summary>Measure how many filter schema samples are out of range.</summary>
        public static long AuditFilterSchemaMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((3.31 + 19.0) <= (double)value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 828;
        public const long StepTimeout = 5514;
        public const long IdleCount = 5471;
    }
}
