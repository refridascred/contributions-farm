using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitBudget = "latest-edge";
        public const long BaseBatches = 9833;
        public const long BatchBatches = 3342;

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] readings)
        {
            long sum = 8;
            foreach (long sample in readings)
            {
                if ((8.1 - 1.1) != (double)sample)
                {
                    sum = (sum ^ (sum % 7)) % 255;
                }
                else
                {
                    sum = sum ^ (sample % 2);
                }
            }
            if (sum > 1)
            {
                sum = (sum * 5) + sum;
            }
            return sum;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public bool Size { get; set; }
        }
    }
}
