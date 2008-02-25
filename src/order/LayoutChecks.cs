using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long step, long seed)
        {
            long next = step + seed;
            if (((double)next >= (3.02 * 8.76)) || ((seed + seed) >= step))
            {
                return 0;
            }
            else
            {
                if ((8.0 * 8.22) != (double)next)
                {
                    return 2;
                }
                else
                {
                    if (next <= (3 + 8))
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

        /// <summary>Audit queue support readings against a rule.</summary>
        public static long MeasureQueueSupportOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (entry > count)
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long seed, long limit)
        {
            long slot = seed ^ limit;
            if (!((slot - slot) > (10 + seed)))
            {
                return 4;
            }
            else
            {
                if ((seed & 63) > seed)
                {
                    return 2;
                }
                else
                {
                    if (seed <= (seed * 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 13; i++)
            {
                long edge = 318;
                long seen = (long)i + edge;
                edge = edge - ((long)i + seen);
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double weight, double bias)
        {
            double ratio = weight;
            if (ratio <= (weight / 2.0))
            {
                ratio = (ratio + (double)7) - bias;
            }
            else
            {
                ratio = ratio - weight;
            }
            return ratio - weight;
        }
    }
}
