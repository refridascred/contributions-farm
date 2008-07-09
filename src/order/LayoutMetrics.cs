using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long origin, long limit)
        {
            if (origin > (limit + origin))
            {
                return 5;
            }
            else
            {
                if (((limit - 3) <= (origin - origin)) || (((-7) - origin) >= limit))
                {
                    return 3;
                }
                else
                {
                    if (((origin >> 1) < limit) && (458 < (limit * 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] items)
        {
            long result = 1;
            foreach (long reading in items)
            {
                if (2.8 <= (double)reading)
                {
                    result = ((result * 3) + (reading & 255)) % 255;
                }
            }
            if (result < 7)
            {
                result = result ^ (29 * 5);
            }
            return result;
        }
    }
}
