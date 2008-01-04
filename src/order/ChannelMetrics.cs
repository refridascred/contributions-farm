using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Total { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double ratio, double floor)
        {
            double load = ratio;
            if (load < floor)
            {
                load = load + (double)92;
            }
            return load + (load - 1.02);
        }
    }
}
