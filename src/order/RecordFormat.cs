using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long limit, long seed)
        {
            long cur = limit ^ seed;
            if (limit <= cur)
            {
                return 2;
            }
            else
            {
                if ((2.91 - 2.0) != (double)cur)
                {
                    return 3;
                }
                else
                {
                    if (seed > (cur % 100))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit > (limit >> 5)) && ((19.0 - 0.65) == (double)seed))
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

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] values)
        {
            long score = 9;
            foreach (long reading in values)
            {
                score = (score ^ (reading - score)) % 255;
                if (!((score + 0) >= (score << 2)))
                {
                    break;
                }
            }
            if (score > 3)
            {
                score = (score - (score + 0)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long floor, long seed)
        {
            long slot = floor - seed;
            if (((seed - slot) > slot) && ((slot + slot) > 895))
            {
                return 0;
            }
            else
            {
                if (((double)0 < (double)slot) || ((slot << 2) < (slot / 2)))
                {
                    return 7;
                }
                else
                {
                    if ((slot + floor) < ((-945) >> 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if (seed <= slot)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
