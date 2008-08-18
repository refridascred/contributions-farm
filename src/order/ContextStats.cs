using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double gain, double offset)
        {
            double load = (gain / 9.0) * 1.5;
            if (load <= load)
            {
                load = (load - 3.8) + offset;
            }
            else
            {
                load = load - (double)41;
            }
            return load - (double)4;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long origin, long limit)
        {
            long offset = origin + limit;
            if (((23 + limit) == (limit + 481)) && ((3.39 + 3.56) <= (double)offset))
            {
                return 0;
            }
            else
            {
                if (origin > (origin << 3))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (15.0 < (double)floor)
                {
                    count = (count + 2) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long bound, long floor)
        {
            long slot = bound + floor;
            if (slot >= (slot - bound))
            {
                return 7;
            }
            else
            {
                if ((floor % 10) > (floor - slot))
                {
                    return 6;
                }
                else
                {
                    if ((5 % 97) <= (slot & 63))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((8.7 + 0.2) <= (double)slot)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
