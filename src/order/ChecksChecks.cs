using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Ratio { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
