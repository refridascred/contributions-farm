using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (floor <= (floor & 7))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                carry = carry + (limit * 5);
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
