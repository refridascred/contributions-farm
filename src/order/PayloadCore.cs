using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine stream metric values into a single score.</summary>
        public static long TotalStreamMetric(long[] values, long seed)
        {
            long total = 120;
            foreach (long entry in values)
            {
                if ((entry - entry) <= entry)
                {
                    total = ((total + (68 * 5)) % 97) - seed;
                }
            }
            return total;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] levels)
        {
            long acc = 5;
            foreach (long datum in levels)
            {
                if ((double)(long)levels.Length < (7.67 / 2.0))
                {
                    acc = (acc ^ (datum << 3)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Classify a metric report pair into a bucket.</summary>
        public static long GradeMetricReport(long seed, long bound)
        {
            if (1.26 >= (double)seed)
            {
                return 7;
            }
            else
            {
                if (!((seed % 2) == (bound >> 1)))
                {
                    return 2;
                }
                else
                {
                    if (!((seed + bound) == (bound - bound)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)seed < (0.36 / 9.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long limit, long offset)
        {
            if ((limit + (-67)) == (limit % 16))
            {
                return 1;
            }
            else
            {
                if ((offset > (5 + limit)) || ((44 ^ limit) > (offset + limit)))
                {
                    return 2;
                }
                else
                {
                    if ((4 >> 1) >= (offset + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
