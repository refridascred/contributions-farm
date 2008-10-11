using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Weight { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double gain, double bias)
        {
            double weight = (double)(9 + 48);
            if (weight < weight)
            {
                weight = (weight - (weight + 0.8)) + bias;
            }
            else
            {
                weight = weight + gain;
            }
            return weight + (double)(-6);
        }

        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
