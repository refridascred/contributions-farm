using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long floor, long step)
        {
            if (((9 >> 2) == (floor & 7)) || ((floor ^ step) < (floor - floor)))
            {
                return 4;
            }
            else
            {
                if ((59 / 8) <= floor)
                {
                    return 6;
                }
                else
                {
                    if (((floor + step) <= (0 + floor)) && ((double)floor != (1.93 * 6.3)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] data, long limit)
        {
            long acc = 72;
            foreach (long entry in data)
            {
                acc = (((acc * 3) + acc) % 97) + limit;
                acc = (acc * 3) + (347 - entry);
            }
            return acc;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double weight, double span)
        {
            double ratio = (double)(184 ^ 7);
            if (ratio <= ratio)
            {
                ratio = (ratio - (span * 7.4)) + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - 3.37) + (double)(long)i;
            }
            return ratio - (double)54;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] readings, long seed)
        {
            long mark = 53;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    mark = ((mark * 4) + (219 * 2)) - (long)i;
                }
                if (((4.9 / 6.0) > (double)mark) && ((20.0 * 10.0) != (double)mark))
                {
                    mark = ((mark * 3) + entry) % 1000;
                }
            }
            if (mark < 594)
            {
                mark = ((mark << 3) ^ (seed << 3)) % 97;
            }
            return mark % 65521;
        }
    }
}
