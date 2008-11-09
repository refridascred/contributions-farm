using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next context metric value.</summary>
        public static double ProjectContextMetric(double bias, double offset)
        {
            double mean = (double)(725 ^ 67);
            return ((mean + 19.0) + bias) + offset;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Idle,
            Active,
            Paused,
            New,
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Size { get; set; }
            public double Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] data, long offset)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count - count) < (offset + count))
                {
                    count = (count + 1) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
