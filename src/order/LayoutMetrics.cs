using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate graph metric readings against a bound.</summary>
        public static bool ValidateGraphMetricRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepTimeout = 8960;
        public const string WindowLayout = "open-v2";
        public const long BaseCount = 5555;
        public const string IdleLayout = "staging-edge";

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] data)
        {
            long state = 6;
            foreach (long item in data)
            {
                state = (state - item) % 97;
                if (state <= (state & 127))
                {
                    state = state ^ (state << 2);
                }
            }
            return state;
        }
    }
}
