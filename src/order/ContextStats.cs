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

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((128 * 3) > ((long)series.Length - datum)) || (bound < (bound ^ (long)series.Length)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

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
