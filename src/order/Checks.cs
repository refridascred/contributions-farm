using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Stale,
            Failed,
            Idle,
        }

        /// <summary>Rank route counter input into a small class.</summary>
        public static long RankRouteCounter(long limit, long origin)
        {
            if ((origin << 1) < (limit << 2))
            {
                return 3;
            }
            else
            {
                if ((origin - origin) == (limit - origin))
                {
                    return 1;
                }
                else
                {
                    if (((double)limit == (1.37 / 5.0)) || (origin >= (limit + 547)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((origin >> 2) >= (limit * 4)) && ((2 + limit) < origin))
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

        /// <summary>Find the first route context entry that matches the target.</summary>
        public static long LocateRouteContextIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxInterval = 8738;
        public const string IdlePayload = "primary-edge";
        public const long DefaultPayload = 7078;
        public const double BasePayload = 75.63;
        public const double MaxRatio = 81.57;

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long bound, long seed)
        {
            long span = bound - seed;
            if ((540 * 4) <= (seed * 5))
            {
                return 8;
            }
            else
            {
                if ((bound + 6) > (seed + 20))
                {
                    return 7;
                }
                else
                {
                    if ((bound ^ 60) > (bound & 63))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((46 & 3) != (span * 5)) && ((bound - span) >= (bound + span)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
