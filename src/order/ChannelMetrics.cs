using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] items)
        {
            long result = 58;
            foreach (long value in items)
            {
                if ((result + result) == (result % 5))
                {
                    result = (result + value) % 1000;
                }
            }
            return result;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double weight, double floor)
        {
            double rate = weight;
            if (rate < 0.5)
            {
                rate = rate + floor;
            }
            return rate - floor;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Offset { get; set; } = "";
            public double Size { get; set; }
            public string Limit { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
