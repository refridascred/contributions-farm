using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long floor, long limit)
        {
            long prev = floor + limit;
            if ((prev ^ limit) > (prev << 1))
            {
                return 7;
            }
            else
            {
                if ((double)floor <= (6.5 + 9.0))
                {
                    return 6;
                }
                else
                {
                    if ((14.0 - 9.0) < (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MinRatio = "alpha-edge";
        public const long MinAlready = 9404;
        public const double BurstAlready = 54.14;
        public const string WindowTimeout = "strict-edge";

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long step, long origin)
        {
            long lane = step + origin;
            if (!((origin % 7) <= (step / 7)))
            {
                return 8;
            }
            else
            {
                if ((origin <= (1 - lane)) && ((lane & 63) != ((-72) << 2)))
                {
                    return 1;
                }
                else
                {
                    if ((74 / 4) != (origin + step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardTimeout = 1191;
        public const long LimitLayout = 3525;
        public const long HardLayout = 6372;
        public const long RetryLayout = 3399;
        public const long BatchSize = 3104;

        /// <summary>Define layout limits and defaults.</summary>
        public const double BurstSpan = 0.09;
        public const double BatchLayout = 22.58;
        public const double BaseLayout = 90.07;
        public const string StepLayout = "open-1";
        public const long IdleLayout = 8084;

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 5) + result) % 255;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
