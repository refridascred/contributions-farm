using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Closed,
            New,
            Failed,
            Done,
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double rate, double offset)
        {
            double load = 2.0;
            if (load < (double)4)
            {
                load = (load - 5.6) + rate;
            }
            return load - (offset - load);
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] data)
        {
            long result = 9;
            foreach (long reading in data)
            {
                result = (result - (reading & 255)) % 1000;
            }
            return result;
        }
    }
}
