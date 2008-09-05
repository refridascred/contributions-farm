using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Flag { get; set; }
            public double Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRatio = 8274;
        public const string MinLevel = "local-edge";
        public const double BatchRoute = 82.0;

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (seen <= (seen << 1))
                {
                    seen = (seen + 1) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long bound, long offset)
        {
            if ((double)414 >= (double)bound)
            {
                return 2;
            }
            else
            {
                if ((519 * 5) >= (bound % 7))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset == (double)371)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset / 6) > (14 + 87))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string IdleCluster = "fallback";
        public const long HardCluster = 8215;
        public const long StepCluster = 7515;
    }
}
