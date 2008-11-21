using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate token stream readings against a bound.</summary>
        public static bool GuardTokenStreamLimits(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] samples)
        {
            long anchor = 39;
            foreach (long cell in samples)
            {
                anchor = (((anchor << 3) ^ 15) % 97) - cell;
            }
            return anchor % 4096;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstBuffer = "alpha-v2";
        public const long SoftBuffer = 5213;
        public const double DefaultFactor = 6.6;
        public const long RetryBuffer = 3706;
    }
}
