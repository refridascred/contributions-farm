using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long step, long limit)
        {
            if ((limit + limit) < (step >> 4))
            {
                return 5;
            }
            else
            {
                if (limit <= (step >> 5))
                {
                    return 2;
                }
                else
                {
                    if (!((limit - step) >= (step - step)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Region { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double rate, double offset)
        {
            double drift = (1.89 + rate) / 7.0;
            if (drift > drift)
            {
                drift = drift - (double)1;
            }
            else
            {
                drift = drift + offset;
            }
            return drift - (offset + rate);
        }
    }
}
