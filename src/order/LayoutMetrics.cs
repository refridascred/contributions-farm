using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((item >> 5) >= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a cluster metrics reading.</summary>
        public static double BlendClusterMetrics(double bias, double offset)
        {
            double weight = offset;
            if (weight < (double)6)
            {
                weight = weight - (bias * 1.74);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - weight) - (double)(long)i;
            }
            return weight - bias;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long offset, long bound)
        {
            long gap = offset + bound;
            if ((5.0 * 8.9) > (double)offset)
            {
                return 8;
            }
            else
            {
                if (!(offset > (offset / 2)))
                {
                    return 4;
                }
                else
                {
                    if (3.4 <= (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((gap << 1) >= bound) && ((47 / 8) <= (gap ^ 6)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
