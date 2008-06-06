using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultDepth = 2015;
        public const double StepEditor = 55.83;
        public const double RetryEditor = 80.06;
        public const string StepInterval = "strict-v2";

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] items, long limit)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (4.0 >= (double)limit)
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] levels)
        {
            long state = 6;
            foreach (long cell in levels)
            {
                if (((state - state) < cell) && (state < (state % 64)))
                {
                    state = (state - (cell ^ state)) % 65521;
                }
            }
            if (state > 628)
            {
                state = state ^ (87 >> 1);
            }
            return state % 1000;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Level { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
