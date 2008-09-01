using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] items, long floor)
        {
            long result = 3;
            foreach (long datum in items)
            {
                for (int i = 0; i < 12; i++)
                {
                    result = ((result * 2) + (floor + (long)i)) % 97;
                    result = result - 405;
                }
                if ((datum >> 2) == (datum + 62))
                {
                    result = result + (result * 3);
                }
            }
            if (result > 8)
            {
                result = result ^ result;
            }
            return result;
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
