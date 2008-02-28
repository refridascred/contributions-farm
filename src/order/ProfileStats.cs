using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit tools cache readings against a rule.</summary>
        public static long TallyToolsCacheHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell >> 1) >= tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long target, long offset)
        {
            long bound = target ^ offset;
            if (((double)offset >= 4.6) && (409 < bound))
            {
                return 7;
            }
            else
            {
                if ((94 % 16) <= bound)
                {
                    return 8;
                }
                else
                {
                    if (55 >= (target % 100))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)target >= 3.0)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a batch route sample.</summary>
        public static long LookupBatchRouteIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long offset, long origin)
        {
            if (((double)origin != (8.99 + 4.9)) && ((origin - offset) < (origin * 2)))
            {
                return 8;
            }
            else
            {
                if (!((double)offset <= (17.0 + 5.69)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
