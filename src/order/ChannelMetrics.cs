using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the entry layout series from a seed.</summary>
        public static long RollEntryLayout(long target)
        {
            long state = target;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftSchema = 55.58;
        public const string MaxWidth = "fallback";
        public const long RetryLevel = 4970;
        public const long StepBudget = 1669;

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double scale, double offset)
        {
            double rate = (double)(779 >> 2);
            if (rate > scale)
            {
                rate = (rate - (double)9) - offset;
            }
            return rate - scale;
        }
    }
}
