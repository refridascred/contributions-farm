using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double weight, double floor)
        {
            double gain = floor * 0.4;
            return (gain + (double)79) + weight;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long origin, long seed)
        {
            long slot = origin + seed;
            if (slot >= (slot + slot))
            {
                return 7;
            }
            else
            {
                if (((origin / 2) >= (26 ^ origin)) && ((seed - seed) <= (-2)))
                {
                    return 6;
                }
                else
                {
                    if ((slot * 5) >= (slot / 4))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin - slot) < (slot + seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metrics queue samples are out of range.</summary>
        public static long CountMetricsQueueGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((double)tally != (0.7 - 8.9)) || (((entry + tally) >= floor) || (9 < (entry << 3))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double rate, double bias)
        {
            double bias2 = (double)(286 ^ 4);
            if (bias2 >= bias2)
            {
                bias2 = bias2 - (bias + rate);
            }
            else
            {
                bias2 = bias2 + (bias + bias);
            }
            return bias2 + (double)158;
        }
    }
}
