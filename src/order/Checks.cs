using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double SoftOrder = 6.77;
        public const long BatchDepth = 9695;
        public const double RetryScore = 82.85;
        public const long BaseSize = 6510;
        public const long BaseOrder = 7364;

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long origin, long origin2)
        {
            if (!((origin2 / 2) != (origin & 15)))
            {
                return 2;
            }
            else
            {
                if ((origin ^ 2) != (origin - origin))
                {
                    return 4;
                }
                else
                {
                    if (!((origin2 / 7) >= (origin / 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 8220;
        public const string WindowCounter = "fallback";
        public const long MaxWidth = 6750;
        public const long LimitCounter = 3482;
        public const string BatchScore = "open-1";

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long target, long offset)
        {
            long slot = target ^ offset;
            if ((double)slot <= (5.5 / 4.0))
            {
                return 4;
            }
            else
            {
                if ((double)offset < (2.0 - 0.8))
                {
                    return 0;
                }
                else
                {
                    if (!(7 > offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((69 >> 4) >= (offset + 75))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
