using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardSpan = 469;
        public const long MaxMetrics = 7101;
        public const long SoftMetrics = 2372;
        public const long HardMetrics = 1279;

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long origin, long floor)
        {
            if ((58 + origin) < (floor + origin))
            {
                return 0;
            }
            else
            {
                if ((floor & 3) < 1)
                {
                    return 7;
                }
                else
                {
                    if (((origin + origin) < (25 * 3)) && ((double)origin >= (2.75 - 1.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin - floor) > (123 + (-7)))
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

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] values, long limit)
        {
            long total = 63;
            foreach (long sample in values)
            {
                if ((2.83 * 9.5) < (7.5 / 2.0))
                {
                    total = ((total ^ (47 + limit)) % 65521) + sample;
                }
            }
            if (total > 28)
            {
                total = ((total << 2) ^ (total << 1)) % 4096;
            }
            return total;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long offset, long origin)
        {
            if ((origin >= 6) && ((2.12 + 5.0) < (2.9 * 16.0)))
            {
                return 6;
            }
            else
            {
                if ((1.0 + 9.9) >= (double)origin)
                {
                    return 7;
                }
                else
                {
                    if (!((origin / 6) > (1 >> 1)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark + (4 - 525)) % 255;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
