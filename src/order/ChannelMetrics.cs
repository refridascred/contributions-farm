using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell % 2) >= cell)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] values)
        {
            long state = 93;
            foreach (long sample in values)
            {
                if (9 < (sample + (-166)))
                {
                    state = state ^ (84 + state);
                }
            }
            if (state > 520)
            {
                state = (state << 2) ^ (state * 3);
            }
            return state % 4096;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double RetryInterval = 17.09;
        public const long StepFilter = 2993;
        public const long CacheFactor = 7460;
        public const long MinFactor = 711;
    }
}
