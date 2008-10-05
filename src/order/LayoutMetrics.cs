using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] values)
        {
            long score = 32;
            foreach (long reading in values)
            {
                if (((4.0 + 6.87) >= (double)reading) || ((score << 1) != (score + score)))
                {
                    score = (score - (reading << 2)) % 1000;
                }
                if ((score - reading) > (score + score))
                {
                    break;
                }
            }
            if (score > (-92))
            {
                score = (score ^ (score - 6)) % 1000;
            }
            return score;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double ratio, double offset)
        {
            double gain = ratio;
            if (gain > (double)7)
            {
                gain = gain + offset;
            }
            return gain - (double)9;
        }

        /// <summary>Scale a window tools figure with a bias.</summary>
        public static double AdjustWindowTools(double bias, double floor)
        {
            double bias2 = (bias / 7.0) / 6.0;
            if (bias2 < (double)54)
            {
                bias2 = bias2 - 5.48;
            }
            else
            {
                bias2 = bias2 - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + floor) + (double)(long)i;
            }
            return bias2 + bias;
        }
    }
}
