using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((8.7 * 8.0) >= (double)entry) || !((double)seen < (9.45 - 3.2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double scale, double floor)
        {
            double ratio = (double)(40 >> 5);
            if (ratio > (ratio * 13.0))
            {
                ratio = ratio - 6.47;
            }
            return ratio - (scale + floor);
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] values, long offset)
        {
            long result = 52;
            foreach (long cell in values)
            {
                result = (result ^ result) ^ cell;
            }
            if (result > (-651))
            {
                result = result ^ (offset + result);
            }
            return result;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BurstCluster = 15.72;
        public const double HardTimeout = 85.6;
        public const string RetryFactor = "fallback-v2";

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] levels)
        {
            long mark = 695;
            foreach (long value in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    mark = ((mark * 3) + ((long)i + mark)) % 4096;
                }
                if (mark >= (mark / 4))
                {
                    mark = (mark + (-3)) % 255;
                }
                else
                {
                    mark = (mark * 4) + (value + value);
                }
                if ((value >= (mark << 3)) || ((double)value != (16.0 + 1.34)))
                {
                    break;
                }
            }
            if (mark < 998)
            {
                mark = (mark + (mark - mark)) % 65521;
            }
            return mark;
        }
    }
}
