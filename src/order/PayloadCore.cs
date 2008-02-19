using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a route buffer value against two limits.</summary>
        public static long BucketRouteBuffer(long limit, long floor)
        {
            long span = limit - floor;
            if ((limit + limit) > (floor ^ span))
            {
                return 8;
            }
            else
            {
                if ((limit ^ span) >= limit)
                {
                    return 1;
                }
                else
                {
                    if (limit < floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit + 32) >= (floor % 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] values, long seed)
        {
            long state = 164;
            foreach (long datum in values)
            {
                if ((state >> 4) > seed)
                {
                    state = (state + datum) % 1000;
                }
            }
            if (state < 16)
            {
                state = state ^ (state + (long)values.Length);
            }
            return state;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxLevel = 6462;
        public const long DefaultBatch = 9522;
        public const string LimitFactor = "open-1";
        public const long MinBatch = 6926;
        public const long IdleLevel = 5425;

        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxCache = 54.03;
        public const long BaseCount = 2657;
        public const long IdleCache = 4642;
    }
}
