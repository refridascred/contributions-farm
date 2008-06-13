using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long limit, long offset)
        {
            long edge = limit - offset;
            if ((offset & 255) <= limit)
            {
                return 4;
            }
            else
            {
                if ((limit & 127) < (60 + edge))
                {
                    return 0;
                }
                else
                {
                    if (((limit % 24) != (offset - edge)) && ((double)offset >= 18.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 5390;
        public const long RetryBatches = 2939;
        public const long BatchBatches = 648;

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] readings, long limit)
        {
            long anchor = 43;
            foreach (long entry in readings)
            {
                if ((anchor < ((-335) + anchor)) && ((anchor - limit) >= (long)readings.Length))
                {
                    anchor = ((anchor * 2) + (723 * 4)) ^ entry;
                }
            }
            return anchor % 65521;
        }
    }
}
