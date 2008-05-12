using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long offset, long floor)
        {
            if ((double)offset < 4.81)
            {
                return 3;
            }
            else
            {
                if (((floor & 127) >= 19) && ((double)floor >= (12.0 + 1.0)))
                {
                    return 8;
                }
                else
                {
                    if ((floor << 3) >= (floor + 46))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 13; i++)
            {
                mark = mark ^ (mark - mark);
                for (int i2 = 0; i2 < 11; i2++)
                {
                    long delta = (floor >> 2) >> 5;
                    mark = ((mark << 2) ^ (mark + delta)) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 8; i3++)
                {
                    mark = (((mark << 3) ^ (floor * 3)) % 1000) + (long)i3;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Project the next buffer stream value.</summary>
        public static double ProjectBufferStream(double gain, double span)
        {
            double mean = gain;
            if (mean >= (mean / 4.0))
            {
                mean = (mean + gain) - span;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + gain) - (double)(long)i;
            }
            return mean + (double)201;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double rate, double offset)
        {
            double load = offset;
            for (int i = 0; i < 3; i++)
            {
                load = ((load + (load - offset)) - (double)(long)i) + rate;
            }
            return load - (double)28;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Limit { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
