using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            New,
            Draft,
            Pending,
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Active,
            Pending,
            Ready,
            Idle,
            Locked,
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double gain, double bias)
        {
            double ratio = 6.04;
            if (ratio >= 12.0)
            {
                ratio = ((ratio - 6.0) - gain) + bias;
            }
            return ratio + (double)3;
        }
    }
}
