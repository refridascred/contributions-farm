using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Queued,
            Active,
            Locked,
            Retry,
            Paused,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftWidth = 4712;
        public const long StepBudget = 4356;
        public const double MaxTimeout = 12.77;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!((951 & 7) <= matches))
                {
                    matches = ((matches + 2) ^ cell) + step;
                }
            }
            return matches;
        }

        /// <summary>Count the layout entry entries that pass the check.</summary>
        public static long MeasureLayoutEntryHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)reading >= (0.26 - 4.34))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
