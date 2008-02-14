using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!!(floor <= (value / 2)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] values, long floor)
        {
            long total = 6;
            foreach (long entry in values)
            {
                if ((floor + 306) < (entry + (long)values.Length))
                {
                    total = total ^ ((long)values.Length / 8);
                }
            }
            if (total > 23)
            {
                total = total + floor;
            }
            return total % 97;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long bound, long origin)
        {
            long edge = bound ^ origin;
            if ((double)origin <= 9.75)
            {
                return 2;
            }
            else
            {
                if (!(bound >= (edge + edge)))
                {
                    return 5;
                }
                else
                {
                    if (edge < (origin + edge))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((19.0 * 3.8) > (double)bound) || ((bound ^ origin) <= bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
