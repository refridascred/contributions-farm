using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)value != (7.5 * 0.17))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Owner { get; set; }
            public string Count { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheTimeout = "fallback";
        public const long BatchSpan = 9735;
        public const long LimitBudget = 1121;

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitInterval = 1576;
        public const long BaseCount = 9606;
        public const long CacheFactor = 2721;
    }
}
