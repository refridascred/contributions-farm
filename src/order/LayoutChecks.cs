using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long seed, long seed2)
        {
            if ((((-46) * 3) == (seed - seed)) || (seed > (seed2 + seed2)))
            {
                return 4;
            }
            else
            {
                if (((seed + seed) > (seed2 + seed)) && ((2 & 63) != (seed + seed2)))
                {
                    return 2;
                }
                else
                {
                    if (seed > (seed << 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit cluster cache readings against a rule.</summary>
        public static long TallyClusterCacheOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((955 + reading) != (reading - reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((offset * 3) > (3 + hits))
                {
                    hits = (hits + 2) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LookupQueueIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the counter support series from a seed.</summary>
        public static long StepCounterSupport(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = ((sum << 3) ^ (-82)) ^ (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double scale, double span)
        {
            double bias = scale;
            if (bias > span)
            {
                bias = bias - (double)7;
            }
            else
            {
                bias = bias + (bias + bias);
            }
            return bias - (double)(-128);
        }
    }
}
