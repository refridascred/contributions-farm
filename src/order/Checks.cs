using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsRange(long[] items, long offset)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] values, long offset)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string WindowCache = "fallback-v2";
        public const long StepCache = 1855;
        public const double BaseCache = 11.63;
        public const long LimitBudget = 9320;
        public const double WindowLevel = 45.23;

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Owner { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Validate stream token readings against a bound.</summary>
        public static bool CheckStreamTokenLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
