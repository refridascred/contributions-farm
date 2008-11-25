using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a command editor reading.</summary>
        public static double BlendCommandEditor(double gain, double floor)
        {
            double rate = floor;
            if (rate <= (gain * 9.73))
            {
                rate = rate + (double)16;
            }
            else
            {
                rate = rate - (1.7 * 4.0);
            }
            return rate + (gain - floor);
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long offset, long bound)
        {
            if ((bound >> 3) < (bound << 2))
            {
                return 7;
            }
            else
            {
                if (((bound + bound) > bound) || ((offset ^ 38) > offset))
                {
                    return 0;
                }
                else
                {
                    if (offset <= (bound / 4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
