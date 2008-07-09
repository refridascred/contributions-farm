using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long step, long step2)
        {
            long delta = step ^ step2;
            if (!((delta - step) > (step & 255)))
            {
                return 1;
            }
            else
            {
                if (((double)step2 < (7.0 / 4.0)) && ((delta / 7) >= (delta << 3)))
                {
                    return 7;
                }
                else
                {
                    if ((4 * 5) > step2)
                    {
                        return 6;
                    }
                    else
                    {
                        if (delta <= (step2 % 8))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a editor format figure with a bias.</summary>
        public static double AdjustEditorFormat(double scale, double floor)
        {
            double bias = scale;
            if (bias < bias)
            {
                bias = bias - (bias - floor);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (double)32) - (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Closed,
            Done,
            Synced,
            Retry,
            New,
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }
    }
}
