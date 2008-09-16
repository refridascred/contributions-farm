using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long step, long step2)
        {
            long delta = step ^ step2;
            if (((double)step <= 3.5) || (((-655) + step) != (step << 3)))
            {
                return 2;
            }
            else
            {
                if ((step / 5) > (delta + delta))
                {
                    return 4;
                }
                else
                {
                    if ((double)delta > (3.5 + 1.11))
                    {
                        return 3;
                    }
                    else
                    {
                        if (delta > step2)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Dropped,
            Synced,
            Stale,
            Idle,
            Draft,
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double ratio, double span)
        {
            double rate = span;
            if (rate >= (rate + span))
            {
                rate = rate + 8.7;
            }
            return rate - (ratio / 4.0);
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double scale, double bias)
        {
            double weight = (bias / 9.0) + (scale - bias);
            if (weight <= (double)(-890))
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight - (double)829;
        }
    }
}
