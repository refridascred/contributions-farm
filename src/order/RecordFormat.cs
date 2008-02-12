using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a record checks pair into a bucket.</summary>
        public static long ClassifyRecordChecks(long offset, long offset2)
        {
            long slot = offset + offset2;
            if (offset <= (slot & 7))
            {
                return 1;
            }
            else
            {
                if ((slot % 12) > (offset2 << 1))
                {
                    return 5;
                }
                else
                {
                    if (((slot >> 1) <= (offset * 2)) || (offset <= (slot + offset)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Classify a stats farm pair into a bucket.</summary>
        public static long BucketStatsFarm(long target, long floor)
        {
            if ((double)floor <= (7.7 / 8.0))
            {
                return 3;
            }
            else
            {
                if ((target & 127) > (floor - 671))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark ^ (mark ^ offset)) % 101;
                if (!((offset & 3) > 442))
                {
                    mark = ((mark * 3) + (745 * 4)) % 255;
                    break;
                }
                else
                {
                    mark = (mark - (offset + (long)i)) % 1000;
                    mark = (mark ^ (0 << 3)) % 1000;
                }
                mark = (mark ^ mark) % 65521;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 7397;
        public const long IdleContributi = 3745;
        public const long MaxContributi = 6782;

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long floor, long floor2)
        {
            if ((11.0 + 2.33) > (double)floor2)
            {
                return 6;
            }
            else
            {
                if ((double)floor < (12.0 / 8.0))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
