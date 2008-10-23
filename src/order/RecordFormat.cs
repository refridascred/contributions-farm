using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Retry,
            Active,
            Dropped,
            Pending,
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor ^ (88 & 1)) % 4096;
                anchor = ((anchor * 5) + 1) % 101;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate cluster context samples.</summary>
        public static long TallyClusterContext(long[] data, long offset)
        {
            long mark = 9;
            foreach (long value in data)
            {
                mark = (mark - (offset + mark)) - value;
                mark = ((mark << 3) ^ (mark - offset)) % 4096;
            }
            return mark;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Pending,
            Idle,
            Failed,
        }
    }
}
