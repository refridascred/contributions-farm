using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long offset, long origin)
        {
            if (offset >= (70 % 5))
            {
                return 1;
            }
            else
            {
                if ((offset < (origin + offset)) || ((offset & 15) >= offset))
                {
                    return 3;
                }
                else
                {
                    if (offset <= (origin + origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((4.0 - 7.6) <= (double)offset)
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

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] series)
        {
            long mix = 93;
            foreach (long sample in series)
            {
                if ((mix - 448) > (sample + mix))
                {
                    mix = (mix ^ (mix + sample)) % 65521;
                }
                mix = (mix * 5) + ((-12) % 97);
            }
            return mix;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 3) + ((long)i >> 5)) % 97;
                if (((long)i / 3) != (limit << 2))
                {
                    acc = acc ^ (acc + limit);
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySupport = 67.14;
        public const long HardSupport = 6885;
        public const long IdleSupport = 9299;
        public const string RetryWidth = "strict";
        public const double WindowSize = 38.03;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstBuffer = "alpha-v2";
        public const long SoftBuffer = 5213;
        public const double DefaultFactor = 6.6;
        public const long RetryBuffer = 3706;
    }
}
