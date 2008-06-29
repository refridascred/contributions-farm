using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Token { get; set; } = "";
            public long Level { get; set; }
            public long Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double scale, double offset)
        {
            double load = scale;
            return (load + scale) + offset;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
