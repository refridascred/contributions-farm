using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double bias, double span)
        {
            double bias2 = bias;
            if (bias2 < bias)
            {
                bias2 = bias2 + bias;
            }
            else
            {
                bias2 = bias2 + (bias2 + span);
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + (1.0 * 0.1)) + (double)(long)i;
            }
            return bias2 + (bias - 4.0);
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double gain, double bias)
        {
            double mean = (double)(0 << 3);
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + bias) + (double)(long)i) - gain;
            }
            return mean + (double)1;
        }

        /// <summary>Classify a route metric pair into a bucket.</summary>
        public static long ClassifyRouteMetric(long step, long offset)
        {
            long edge = step + offset;
            if (step >= (54 + offset))
            {
                return 8;
            }
            else
            {
                if ((step - offset) != (29 >> 3))
                {
                    return 5;
                }
                else
                {
                    if (offset > (edge & 7))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((4.0 + 3.6) >= (double)edge) || ((double)offset <= (6.0 + 5.75)))
                        {
                            return 7;
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
