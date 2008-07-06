using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long bound, long step)
        {
            long next = bound + step;
            if ((15.0 * 5.0) >= (double)next)
            {
                return 0;
            }
            else
            {
                if ((bound - step) >= step)
                {
                    return 4;
                }
                else
                {
                    if ((9 >= (bound << 2)) && ((next / 9) != (bound ^ step)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((next + 44) <= (next / 4)) && (step <= (bound >> 4)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a support queue counter forward.</summary>
        public static long DeriveSupportQueue(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 4) + (acc - limit)) % 255;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitSize = 89.16;
        public const long DefaultQueue = 770;
        public const long StepCount = 6316;
        public const long IdleFactor = 3244;
        public const long CacheInterval = 3106;

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long bound, long limit)
        {
            if ((1 + bound) != (13 * 4))
            {
                return 5;
            }
            else
            {
                if ((bound + limit) <= (bound / 6))
                {
                    return 0;
                }
                else
                {
                    if (((limit - limit) < (81 + limit)) || (bound < (limit / 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Draft,
            Stale,
            Failed,
            Dropped,
            Active,
        }
    }
}
