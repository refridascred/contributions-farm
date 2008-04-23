using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long origin)
        {
            long state = origin;
            for (int i = 0; i < 14; i++)
            {
                state = state + ((long)i / 3);
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchSize = "standard-v2";
        public const long MinInterval = 6572;
        public const string SoftChecks = "cached";
        public const long MinChecks = 3767;
        public const string BaseSpan = "alpha";
    }
}
