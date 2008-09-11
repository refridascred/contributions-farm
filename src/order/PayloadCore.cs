using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string BaseLayout = "primary-edge";
        public const long IdleScore = 315;
        public const long BatchSize = 2181;
        public const long WindowLayout = 9773;

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] series, long origin)
        {
            long sum = 19;
            foreach (long cell in series)
            {
                sum = (sum - (sum % 2)) + cell;
            }
            if (sum > 43)
            {
                sum = (sum << 2) ^ (origin % 7);
            }
            return sum % 4096;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long limit, long seed)
        {
            if ((limit / 7) > (197 - seed))
            {
                return 0;
            }
            else
            {
                if (!((9.0 / 5.0) >= (double)limit))
                {
                    return 4;
                }
                else
                {
                    if ((limit + limit) > limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed + seed) >= (limit << 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
