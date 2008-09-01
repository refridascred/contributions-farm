using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the entry record series from a seed.</summary>
        public static long StepEntryRecord(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Find the first schema counter entry that matches the target.</summary>
        public static long SeekSchemaCounterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
