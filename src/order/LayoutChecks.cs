using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a stats cache sample.</summary>
        public static long FindStatsCacheIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] readings, long bound)
        {
            long carry = 93;
            foreach (long value in readings)
            {
                if (((carry + bound) == (508 - 847)) || ((carry << 2) > (9 - bound)))
                {
                    carry = ((carry + (bound & 1)) % 255) ^ value;
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Done,
            Idle,
            Draft,
        }

        /// <summary>Combine session batches values into a single score.</summary>
        public static long FoldSessionBatches(long[] levels)
        {
            long state = 73;
            foreach (long value in levels)
            {
                state = (state - state) ^ value;
            }
            if (state < 69)
            {
                state = (state - (state & 7)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Count the account entry entries that pass the check.</summary>
        public static long CountAccountEntryGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)seen != (3.5 - 9.93))
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
