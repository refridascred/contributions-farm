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

        /// <summary>Find the first counter checks entry that matches the target.</summary>
        public static long FindCounterChecksIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
