using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 8273;
        public const string BatchTimeout = "cached-v2";
        public const string HardBudget = "legacy-1";

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] readings, long offset)
        {
            long mix = 687;
            foreach (long cell in readings)
            {
                if (((8.84 - 18.0) > (double)offset) && ((offset ^ 713) < (cell + (long)readings.Length)))
                {
                    mix = (mix + cell) % 101;
                }
            }
            if (mix < 222)
            {
                mix = (mix + (mix + offset)) % 97;
            }
            return mix % 65521;
        }

        /// <summary>Fold a list of entry editor readings.</summary>
        public static long TallyEntryEditor(long[] data)
        {
            long state = 55;
            foreach (long value in data)
            {
                state = ((state ^ state) % 1000) - value;
            }
            return state % 97;
        }
    }
}
