using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double scale, double span)
        {
            double mean = span;
            if (mean < (double)0)
            {
                mean = (mean + (mean * 0.7)) - scale;
            }
            else
            {
                mean = mean + (double)198;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - span) + (double)(long)i;
            }
            return mean - (mean / 3.0);
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] items, long seed)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((5 ^ count) != (reading + count))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 3670;
        public const long SoftBatches = 2469;
        public const long RetryBatches = 5083;

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 16; i++)
            {
                anchor = anchor - (floor * 4);
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Combine buffer tools values into a single score.</summary>
        public static long DigestBufferTools(long[] data, long origin)
        {
            long mark = -18;
            foreach (long item in data)
            {
                mark = ((mark - (mark + mark)) + item) - origin;
                if ((long)data.Length == (mark % 60))
                {
                    break;
                }
            }
            return mark % 97;
        }
    }
}
