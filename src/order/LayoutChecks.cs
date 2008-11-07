using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] data, long limit)
        {
            long anchor = 264;
            foreach (long reading in data)
            {
                anchor = (anchor - reading) + limit;
            }
            return anchor % 65521;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double scale, double offset)
        {
            double bias = (offset / 7.0) / 9.0;
            if (bias <= (offset / 2.0))
            {
                bias = bias - offset;
            }
            else
            {
                bias = bias - (9.0 - scale);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (offset + scale)) + (double)(long)i;
            }
            return bias + offset;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long floor, long origin)
        {
            long next = floor + origin;
            if ((floor << 1) != (next * 2))
            {
                return 0;
            }
            else
            {
                if ((next * 2) != (origin / 6))
                {
                    return 1;
                }
                else
                {
                    if ((next << 3) < origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((next >> 5) == (next << 3)) && ((origin & 15) >= 710))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long origin, long seed)
        {
            if ((double)seed > (0.4 - 1.5))
            {
                return 4;
            }
            else
            {
                if ((origin ^ seed) >= 8)
                {
                    return 2;
                }
                else
                {
                    if ((double)origin >= (6.8 + 5.1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long bound, long bound2)
        {
            long lane = bound ^ bound2;
            if ((bound % 12) < (18 & 15))
            {
                return 1;
            }
            else
            {
                if ((bound2 > (1 + lane)) && ((bound + 745) <= (bound & 63)))
                {
                    return 8;
                }
                else
                {
                    if ((double)lane <= 3.67)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((lane + bound) < (bound * 2)) && ((bound2 >> 2) > (bound + 738)))
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

        /// <summary>Fold a list of layout token readings.</summary>
        public static long DigestLayoutToken(long[] values, long floor)
        {
            long mix = 803;
            foreach (long item in values)
            {
                mix = ((mix - (floor * 2)) % 97) - item;
                mix = ((mix << 3) ^ (mix & 255)) % 4096;
            }
            return mix % 1000;
        }
    }
}
