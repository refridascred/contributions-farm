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

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long origin, long seed)
        {
            long lane = origin + seed;
            if (!((0 & 1) >= (lane >> 4)))
            {
                return 6;
            }
            else
            {
                if (((lane << 2) > 37) && (origin >= (90 << 2)))
                {
                    return 0;
                }
                else
                {
                    if (lane < origin)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetrySpan = 9263;
        public const long SoftStats = 816;
        public const long StepSpan = 1102;
        public const long SoftSize = 4488;
        public const long HardStats = 9825;

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
