using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a filter session pair into a bucket.</summary>
        public static long GradeFilterSession(long limit, long limit2)
        {
            if ((8.33 - 0.85) != (double)limit)
            {
                return 1;
            }
            else
            {
                if (((limit2 - limit2) >= (limit2 - (-62))) && ((limit + limit2) > (limit / 6)))
                {
                    return 0;
                }
                else
                {
                    if (limit < (limit + 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((limit2 + 69) < 163) && ((limit + limit2) <= (2 * 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every schema stats entry stays within the limit.</summary>
        public static bool CheckSchemaStatsBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next layout stream value.</summary>
        public static double SmoothLayoutStream(double weight, double offset)
        {
            double rate = weight;
            if (rate > (offset * 7.0))
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (double)760) - (double)(long)i;
            }
            return rate - (rate + rate);
        }
    }
}
