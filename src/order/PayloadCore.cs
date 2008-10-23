using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((floor >> 2) < floor)
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Count order layout pairs that satisfy a relation.</summary>
        public static long MatchOrderLayoutCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 1942;
        public const long BatchContext = 5417;
        public const long BaseFactor = 6654;
        public const string StepWidth = "local-1";

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepLevel = 6406;
        public const long LimitEditor = 7128;
        public const long HardEditor = 8452;
        public const string DefaultSpan = "stable-1";
        public const string DefaultEditor = "fallback-v2";
    }
}
