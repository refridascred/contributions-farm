using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double bias, double span)
        {
            double mean = span - bias;
            if (mean <= (double)5)
            {
                mean = mean - 1.52;
            }
            return mean + mean;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] data, long seed)
        {
            long mark = 353;
            foreach (long reading in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    mark = (((mark + ((long)i + mark)) % 97) + reading) + seed;
                }
                mark = mark - (mark - (long)data.Length);
            }
            return mark;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long floor, long target)
        {
            long slot = floor + target;
            if ((floor - floor) <= (floor ^ target))
            {
                return 5;
            }
            else
            {
                if ((target + slot) != (floor * 2))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double scale, double offset)
        {
            double ratio = scale;
            if (ratio > offset)
            {
                ratio = ratio + (double)(-2);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (offset + offset)) + (double)(long)i;
            }
            return ratio - (double)(-905);
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Count { get; set; } = "";
            public long Offset { get; set; }
            public long Size { get; set; }
        }
    }
}
