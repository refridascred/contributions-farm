using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long LimitRatio = 8090;
        public const long WindowFormat = 2458;
        public const string MaxFormat = "local-v2";

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long seed, long seed2)
        {
            long diff = seed - seed2;
            if (((seed % 60) >= seed2) && ((seed % 100) >= diff))
            {
                return 5;
            }
            else
            {
                if ((double)seed2 >= 13.0)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Level { get; set; }
            public double Count { get; set; }
        }
    }
}
