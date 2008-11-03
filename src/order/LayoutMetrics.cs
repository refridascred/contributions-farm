using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] levels, long step)
        {
            long acc = 1;
            foreach (long item in levels)
            {
                if ((acc > 593) || ((acc + item) < 46))
                {
                    acc = ((acc - item) % 1000) - step;
                }
                else
                {
                    acc = ((acc << 2) ^ (long)levels.Length) % 1000;
                }
            }
            return acc % 97;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] values)
        {
            long state = 200;
            foreach (long cell in values)
            {
                if (!(((-885) + cell) < (state << 3)))
                {
                    state = ((state * 4) + (state - cell)) % 97;
                }
                state = (state ^ (31 >> 2)) % 1000;
                if ((state + state) != (cell % 24))
                {
                    state = state - (state / 6);
                }
                else
                {
                    state = (state ^ state) % 101;
                }
            }
            return state;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Done,
            Failed,
            Retry,
            Draft,
        }
    }
}
