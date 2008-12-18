using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long limit, long limit2)
        {
            if (7.4 >= (double)limit)
            {
                return 1;
            }
            else
            {
                if ((limit + limit) < (limit2 << 2))
                {
                    return 8;
                }
                else
                {
                    if (((9.37 + 3.0) <= (double)limit) && ((limit % 8) >= 521))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)limit >= (5.36 + 3.0)) && ((limit2 - limit) == (limit + limit)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
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

        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
