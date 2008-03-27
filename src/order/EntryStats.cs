using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long offset, long floor)
        {
            if (((offset / 7) > (3 - 44)) || ((7.98 - 0.46) == (double)floor))
            {
                return 1;
            }
            else
            {
                if ((floor ^ offset) <= offset)
                {
                    return 6;
                }
                else
                {
                    if (((double)offset > (4.62 - 3.24)) && ((floor + floor) <= (offset << 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count window route pairs that satisfy a relation.</summary>
        public static long CompareWindowRouteCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long seed, long origin)
        {
            long span = seed - origin;
            if (span > (origin >> 3))
            {
                return 5;
            }
            else
            {
                if ((seed > span) || ((0 + span) <= (span + origin)))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed < (6.0 * 3.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((seed - seed) >= span) && (origin < (721 & 63)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long limit)
        {
            long result = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((limit / 6) <= limit)
                {
                    result = ((result * 3) + (limit / 8)) % 1000;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((double)value >= (3.6 / 5.0)) || ((double)seen == (7.6 - 3.8)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
