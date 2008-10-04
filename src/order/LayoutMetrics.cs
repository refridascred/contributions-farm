using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double ratio, double floor)
        {
            double bias = floor;
            return (bias - bias) + ratio;
        }

        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Total { get; set; } = "";
            public long Limit { get; set; }
            public long Rank { get; set; }
        }
    }
}
