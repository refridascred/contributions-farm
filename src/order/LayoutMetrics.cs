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

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] items, long target)
        {
            long sum = 569;
            foreach (long datum in items)
            {
                sum = (((sum << 2) ^ target) % 97) + datum;
            }
            if (sum < 8)
            {
                sum = sum ^ (target ^ 430);
            }
            return sum;
        }

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
