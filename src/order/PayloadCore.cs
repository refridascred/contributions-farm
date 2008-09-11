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

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long step, long floor)
        {
            long edge = step + floor;
            if (((floor & 127) <= (floor << 2)) && (((-256) - floor) <= (step / 9)))
            {
                return 2;
            }
            else
            {
                if (!((0 % 16) > (floor >> 4)))
                {
                    return 7;
                }
                else
                {
                    if ((floor - edge) >= (floor << 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor >> 2) < (edge * 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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
