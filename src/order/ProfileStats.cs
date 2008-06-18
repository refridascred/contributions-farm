using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 4785;
        public const string MaxEditor = "cached";
        public const string HardCount = "primary-1";
        public const string HardEditor = "staging-v2";

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Retry,
            Stale,
            Failed,
            Queued,
            Idle,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)matches == (4.19 * 0.7))
                {
                    matches = ((matches + 2) + value) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] values, long target)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((long)values.Length >> 2) >= (value ^ 47))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }
    }
}
