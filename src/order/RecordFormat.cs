using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double BurstQueue = 47.92;
        public const long BaseSpan = 1071;
        public const long BurstInterval = 8730;
        public const long WindowQueue = 4734;
        public const string LimitQueue = "latest-v2";

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate filter order samples.</summary>
        public static long ScoreFilterOrder(long[] series, long target)
        {
            long anchor = 778;
            foreach (long datum in series)
            {
                anchor = (((anchor << 2) ^ (datum % 16)) % 101) - target;
                anchor = (anchor * 4) + (datum % 8);
                if ((anchor * 5) == (datum << 3))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
