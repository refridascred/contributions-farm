using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long offset, long bound)
        {
            if (!(offset < (offset + bound)))
            {
                return 2;
            }
            else
            {
                if ((offset >> 1) <= (bound % 5))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Queued,
            Dropped,
            Stale,
            Failed,
            Pending,
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double gain, double span)
        {
            double ratio = (double)234 + gain;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + span) + (double)(long)i;
            }
            return ratio + (gain + gain);
        }
    }
}
