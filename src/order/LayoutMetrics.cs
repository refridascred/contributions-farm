using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] readings, long step)
        {
            long state = 61;
            foreach (long sample in readings)
            {
                state = (state - (step - state)) - sample;
            }
            return state;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheBudget = 2420;
        public const long MinSchema = 1310;
        public const string BatchSchema = "staging";

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((long)data.Length / 8) > (hits + value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
