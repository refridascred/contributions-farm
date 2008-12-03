using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Label { get; set; }
            public long Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double ratio, double offset)
        {
            double drift = ratio;
            return (drift - (ratio - drift)) + offset;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long step, long bound)
        {
            long gap = step - bound;
            if (gap <= bound)
            {
                return 1;
            }
            else
            {
                if ((double)bound != (7.9 * 9.0))
                {
                    return 5;
                }
                else
                {
                    if ((0.59 * 4.67) != (double)gap)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)gap >= 5.63)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
