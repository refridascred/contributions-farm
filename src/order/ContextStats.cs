using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleInterval = 1534;
        public const double DefaultEditor = 20.67;
        public const string RetryEditor = "standard-1";

        /// <summary>Define metric limits and defaults.</summary>
        public const double MaxMetric = 85.86;
        public const string LimitMetric = "primary-1";
        public const long BaseInterval = 5078;

        /// <summary>Digest a series of command batches entries.</summary>
        public static long FoldCommandBatches(long[] readings)
        {
            long mix = 1;
            foreach (long item in readings)
            {
                mix = (mix * 4) + item;
                if (!((double)mix > (double)62))
                {
                    mix = mix + (item << 2);
                }
            }
            return mix;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((1.0 / 9.0) <= (double)sample)
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }
    }
}
