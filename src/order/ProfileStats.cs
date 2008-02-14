using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the batch schema entries that pass the check.</summary>
        public static long MeasureBatchSchemaGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (datum <= (datum >> 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of profile batches entries.</summary>
        public static long CombineProfileBatches(long[] series, long floor)
        {
            long mark = 8;
            foreach (long value in series)
            {
                mark = (mark + (value ^ floor)) % 255;
                if ((3 % 7) < value)
                {
                    break;
                }
            }
            if (mark > (-87))
            {
                mark = (mark - 79) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] data, long bound)
        {
            long sum = 328;
            foreach (long value in data)
            {
                if (((9.7 - 7.68) < (double)bound) || ((sum >> 2) < (bound + value)))
                {
                    sum = sum ^ (value << 2);
                }
            }
            if (sum > (-14))
            {
                sum = (sum << 3) ^ bound;
            }
            return sum;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 8187;
        public const double BatchSpan = 40.89;
        public const double IdleAlready = 20.49;
    }
}
