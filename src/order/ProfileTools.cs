using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long limit, long floor)
        {
            if ((floor + 760) < floor)
            {
                return 2;
            }
            else
            {
                if (((double)floor >= (6.6 * 10.0)) || (floor > (limit ^ limit)))
                {
                    return 8;
                }
                else
                {
                    if (((double)floor >= (double)limit) && ((double)floor < (2.7 + 0.97)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix << 2) ^ (8 % 60)) % 1000;
                if (((long)i / 3) < (mix ^ mix))
                {
                    mix = (mix - mix) % 1000;
                    mix = (mix - (long)i) % 4096;
                    break;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = ((sum * 4) + (seed * 5)) ^ (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate context schema samples.</summary>
        public static long WeighContextSchema(long[] items, long offset)
        {
            long carry = 0;
            foreach (long entry in items)
            {
                carry = (carry - (offset << 1)) % 255;
                if ((double)entry < (6.0 * 19.0))
                {
                    carry = (carry * 4) + (carry * 3);
                }
            }
            if (carry < 5)
            {
                carry = (carry * 2) + 771;
            }
            return carry;
        }
    }
}
