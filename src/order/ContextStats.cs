using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit githubfarm support readings against a rule.</summary>
        public static long CountGithubfarmSupportMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches >= (sample / 6)) && (((double)sample >= (7.5 + 1.3)) && ((sample / 8) >= (matches - sample))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 5; i++)
            {
                mark = (mark << 3) ^ (floor ^ floor);
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Idle,
            Locked,
            Paused,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] values)
        {
            long sum = 351;
            foreach (long value in values)
            {
                if (!((180 >> 1) >= sum))
                {
                    sum = sum - (39 + value);
                }
            }
            return sum;
        }
    }
}
