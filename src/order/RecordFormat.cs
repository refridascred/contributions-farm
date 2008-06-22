using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] series, long target)
        {
            long acc = 96;
            foreach (long datum in series)
            {
                if ((datum - target) > (datum + target))
                {
                    acc = ((acc << 2) ^ (target - (-44))) % 97;
                }
            }
            if (acc < 776)
            {
                acc = ((acc << 3) ^ (acc + acc)) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((long)data.Length + (-2)) <= (bound + 9))
                {
                    count = (count + 3) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                result = ((result << 3) ^ (result << 2)) % 4096;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
