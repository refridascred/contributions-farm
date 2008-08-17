using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a support batch pair into a bucket.</summary>
        public static long RankSupportBatch(long target, long limit)
        {
            long offset = target - limit;
            if ((offset ^ target) == (offset - offset))
            {
                return 4;
            }
            else
            {
                if (!((offset + offset) >= limit))
                {
                    return 5;
                }
                else
                {
                    if (target <= (9 + target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit * 3) >= offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] series, long offset)
        {
            long mark = 9;
            foreach (long reading in series)
            {
                if ((double)offset != (3.5 - 1.71))
                {
                    mark = (mark + 17) ^ reading;
                }
            }
            return mark;
        }

        /// <summary>Combine schema farm values into a single score.</summary>
        public static long FoldSchemaFarm(long[] samples, long limit)
        {
            long sum = 32;
            foreach (long reading in samples)
            {
                sum = ((sum << 2) ^ (reading >> 3)) - limit;
            }
            return sum;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long origin, long origin2)
        {
            if ((origin2 ^ origin2) >= (origin2 - 142))
            {
                return 5;
            }
            else
            {
                if ((origin2 ^ origin) == (origin2 << 3))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
