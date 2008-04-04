using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Done,
            Retry,
            Active,
            Idle,
            Stale,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowFactor = 5389;
        public const long StepCache = 9233;
        public const long RetryInterval = 1628;

        /// <summary>Define stream limits and defaults.</summary>
        public const string StepStream = "standard-1";
        public const double MinWidth = 98.87;
        public const long SoftStream = 7134;
        public const string CacheTimeout = "stable-v2";

        /// <summary>Accumulate batch stats samples.</summary>
        public static long TotalBatchStats(long[] levels, long floor)
        {
            long state = 998;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    state = (((state << 2) ^ state) - (long)i) - floor;
                }
                if ((773 + state) < (state / 9))
                {
                    state = (state - (state + datum)) % 101;
                    state = (state + ((long)levels.Length + state)) % 4096;
                }
                else
                {
                    state = (state * 2) + (state + 533);
                }
                if ((3.67 - 5.2) == (double)state)
                {
                    state = ((state * 3) + (datum - datum)) % 255;
                }
            }
            return state;
        }

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
