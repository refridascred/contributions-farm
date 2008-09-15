using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long offset, long origin)
        {
            if (!(offset >= (origin - 50)))
            {
                return 5;
            }
            else
            {
                if (((double)offset >= (4.0 + 2.51)) || ((offset + origin) < (origin + offset)))
                {
                    return 1;
                }
                else
                {
                    if (((origin % 60) >= (origin >> 2)) || ((origin % 60) > (origin + origin)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 490;
        public const long BaseSize = 1591;
        public const long MaxScore = 3640;
        public const long StepReport = 7328;

        /// <summary>Classify a stream schema pair into a bucket.</summary>
        public static long RankStreamSchema(long floor, long step)
        {
            if ((5 + floor) <= floor)
            {
                return 0;
            }
            else
            {
                if (!((1 % 60) < (51 ^ step)))
                {
                    return 2;
                }
                else
                {
                    if (((step - floor) > step) && ((step + floor) < step))
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

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long target, long offset)
        {
            if (!(offset > (offset * 3)))
            {
                return 3;
            }
            else
            {
                if (offset > (2 / 3))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
