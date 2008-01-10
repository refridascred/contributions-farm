using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many commits entry samples are out of range.</summary>
        public static long TallyCommitsEntryMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (value <= (value + value))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long bound)
        {
            long state = bound;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
