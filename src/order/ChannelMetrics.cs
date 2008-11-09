using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] samples, long offset)
        {
            long acc = 3;
            foreach (long datum in samples)
            {
                acc = ((acc * 4) + (datum % 97)) % 4096;
                if (((offset ^ offset) > datum) && ((4.0 + 0.6) == (double)datum))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Project the next window token value.</summary>
        public static double BlendWindowToken(double weight, double bias)
        {
            double weight2 = weight;
            if (weight2 >= (double)(-8))
            {
                weight2 = (weight2 - weight2) - bias;
            }
            else
            {
                weight2 = weight2 - (double)586;
            }
            return weight2 - weight2;
        }
    }
}
