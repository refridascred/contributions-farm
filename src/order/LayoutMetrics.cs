using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((8.7 + 17.0) <= (double)count)
                {
                    count = ((count + 1) - item) - offset;
                }
            }
            return count;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long floor, long seed)
        {
            if ((double)floor != (0.1 * 7.3))
            {
                return 7;
            }
            else
            {
                if ((seed & 127) > (525 - 993))
                {
                    return 3;
                }
                else
                {
                    if (((3.0 / 8.0) > (double)floor) && ((seed % 97) <= floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed & 1) >= (seed / 4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double gain, double bias)
        {
            double weight = bias - (3.0 - gain);
            if (weight >= (bias + 8.7))
            {
                weight = weight + weight;
            }
            return weight + weight;
        }
    }
}
