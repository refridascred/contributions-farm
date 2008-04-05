using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Locked,
            Failed,
            Closed,
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 12; i++)
            {
                if (((double)mark > 6.0) && ((2 - 766) >= (mark + mark)))
                {
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Draft,
            Active,
            Locked,
            Paused,
            Idle,
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 1826;
        public const long MaxLayout = 1498;
        public const string BatchSize = "fallback";
        public const string BurstDepth = "standard-edge";
        public const long StepLayout = 9398;
    }
}
