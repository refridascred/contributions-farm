using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double ratio, double span)
        {
            double gain = (double)(54 / 5);
            if (gain >= gain)
            {
                gain = ((gain - (double)70) - ratio) - span;
            }
            return gain + (3.13 / 2.0);
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long target, long origin)
        {
            if (((-5) << 3) < (target - origin))
            {
                return 7;
            }
            else
            {
                if (231 <= target)
                {
                    return 6;
                }
                else
                {
                    if ((origin ^ origin) <= (origin & 127))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            New,
            Active,
            Dropped,
            Ready,
            Idle,
        }
    }
}
