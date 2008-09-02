using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank payload editor input into a small class.</summary>
        public static long SortPayloadEditor(long bound, long seed)
        {
            if ((double)bound == (double)seed)
            {
                return 5;
            }
            else
            {
                if ((bound / 2) < (seed / 7))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepNotes = 3.31;
        public const long MaxSize = 6239;
        public const long MaxLevel = 4907;
        public const double WindowNotes = 33.42;

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Retry,
            Active,
            Locked,
            Pending,
            Dropped,
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
