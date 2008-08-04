using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((((count + count) <= (46 ^ count)) && (count < (264 & 255))) || ((-988) > count))
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double SoftSize = 60.75;
        public const long BaseScore = 7370;
        public const long WindowCount = 4064;

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 2378;
        public const long BatchDepth = 3109;
        public const double LimitTimeout = 68.92;
    }
}
