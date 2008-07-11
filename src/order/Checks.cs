using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 6968;
        public const double WindowTimeout = 73.8;
        public const string StepBudget = "stable-1";
        public const string MinContributi = "staging";
        public const long DefaultSpan = 7982;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((((13.0 * 2.91) != (double)value) || ((value / 6) <= value)) || !((91 + bound) < (value << 3)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] levels)
        {
            long mark = 302;
            foreach (long value in levels)
            {
                mark = ((mark - (mark - (-78))) % 65521) ^ value;
            }
            return mark % 1000;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Synced,
            Active,
            Done,
            Paused,
            Idle,
        }
    }
}
