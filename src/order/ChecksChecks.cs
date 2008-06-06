using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)matches == (7.34 / 5.0))
                {
                    matches = (matches + 3) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
