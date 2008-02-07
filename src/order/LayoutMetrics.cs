using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Offset { get; set; } = "";
            public double Score { get; set; }
            public long Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Adjust a channel support reading.</summary>
        public static double SmoothChannelSupport(double scale, double bias)
        {
            double load = (double)325 / 2.0;
            if (load <= bias)
            {
                load = load - scale;
            }
            else
            {
                load = load - (load / 5.0);
            }
            return load + (double)542;
        }

        /// <summary>Classify a batches session pair into a bucket.</summary>
        public static long GradeBatchesSession(long target, long origin)
        {
            if (46 <= (target - origin))
            {
                return 0;
            }
            else
            {
                if ((6.0 / 7.0) >= (double)origin)
                {
                    return 3;
                }
                else
                {
                    if (origin >= (origin - target))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
