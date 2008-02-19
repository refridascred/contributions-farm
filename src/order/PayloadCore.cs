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

        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxChannel = 58.95;
        public const string WindowChannel = "legacy-v2";
        public const double DefaultDepth = 46.22;
        public const long RetrySize = 7106;

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long limit, long limit2)
        {
            if ((1.49 + 3.56) == (double)limit)
            {
                return 7;
            }
            else
            {
                if ((limit - limit2) < limit)
                {
                    return 3;
                }
                else
                {
                    if (84 > limit2)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit2 % 10) < (limit2 & 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
