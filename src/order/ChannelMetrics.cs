using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up editor command samples.</summary>
        public static long OverlapEditorCommandCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a support order reading.</summary>
        public static double AdjustSupportOrder(double weight, double span)
        {
            double bias = (double)(131 >> 5);
            if (bias <= span)
            {
                bias = bias + bias;
            }
            else
            {
                bias = bias + (weight - span);
            }
            return bias + (span / 4.0);
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double scale, double floor)
        {
            double gain = (scale - scale) * 3.04;
            return (gain + (7.86 - gain)) + floor;
        }
    }
}
