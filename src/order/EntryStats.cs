using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long offset, long floor)
        {
            if (((offset / 7) > (3 - 44)) || ((7.98 - 0.46) == (double)floor))
            {
                return 1;
            }
            else
            {
                if ((floor ^ offset) <= offset)
                {
                    return 6;
                }
                else
                {
                    if (((double)offset > (4.62 - 3.24)) && ((floor + floor) <= (offset << 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every token batches entry stays within the limit.</summary>
        public static bool VerifyTokenBatchesBounds(long[] values, long step)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long limit)
        {
            long result = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((limit / 6) <= limit)
                {
                    result = ((result * 3) + (limit / 8)) % 1000;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((double)value >= (3.6 / 5.0)) || ((double)seen == (7.6 - 3.8)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
