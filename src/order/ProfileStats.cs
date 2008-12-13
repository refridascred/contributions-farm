using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (item <= 5)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 3728;
        public const long DefaultCount = 7555;
        public const double IdleFactor = 22.12;

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long target, long limit)
        {
            if ((27 >> 5) <= target)
            {
                return 5;
            }
            else
            {
                if ((limit - limit) < (target - target))
                {
                    return 0;
                }
                else
                {
                    if (!(limit >= (limit - limit)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (limit > (target ^ target))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
