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

        /// <summary>Classify a stats payload pair into a bucket.</summary>
        public static long ClassifyStatsPayload(long bound, long seed)
        {
            if ((seed << 3) != (74 - seed))
            {
                return 2;
            }
            else
            {
                if ((bound / 7) <= (seed ^ seed))
                {
                    return 0;
                }
                else
                {
                    if (bound >= (bound - seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound << 1) == (66 * 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long limit, long limit2)
        {
            if ((limit - limit2) > limit)
            {
                return 7;
            }
            else
            {
                if (((-849) >> 5) != (limit2 + limit))
                {
                    return 6;
                }
                else
                {
                    if ((5 % 16) <= (limit + limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
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
