using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] series)
        {
            long sum = 16;
            foreach (long datum in series)
            {
                sum = sum + (datum + 50);
                if (sum < (sum * 2))
                {
                    break;
                }
            }
            if (sum < 34)
            {
                sum = (sum + (sum << 1)) % 97;
            }
            return sum;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Ratio { get; set; }
            public bool Offset { get; set; }
            public string Total { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Count { get; set; }
            public long Weight { get; set; }
        }
    }
}
