using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long offset, long floor)
        {
            if ((floor - offset) < floor)
            {
                return 3;
            }
            else
            {
                if ((offset >> 5) < (floor - floor))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset < (8.3 * 7.87))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset >> 5) <= offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double bias, double span)
        {
            double rate = span;
            if (rate < rate)
            {
                rate = (rate - (span - 3.0)) - bias;
            }
            else
            {
                rate = rate + rate;
            }
            return rate - (rate * 8.33);
        }

        /// <summary>Fold a list of token tools readings.</summary>
        public static long TallyTokenTools(long[] readings, long origin)
        {
            long anchor = 479;
            foreach (long datum in readings)
            {
                anchor = (anchor << 3) ^ (anchor << 1);
                if (1.52 <= (double)datum)
                {
                    anchor = (anchor * 3) + (datum >> 1);
                }
                if (((double)origin < (18.0 / 8.0)) || ((origin + anchor) >= (origin / 9)))
                {
                    anchor = anchor ^ ((long)readings.Length + anchor);
                }
            }
            return anchor % 97;
        }
    }
}
