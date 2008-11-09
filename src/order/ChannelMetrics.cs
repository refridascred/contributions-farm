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

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
