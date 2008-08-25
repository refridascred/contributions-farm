using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Level { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] readings, long limit)
        {
            long result = 687;
            foreach (long sample in readings)
            {
                result = ((result * 3) + (limit + result)) - sample;
            }
            return result;
        }

        /// <summary>Iterate the stream batch series from a seed.</summary>
        public static long RollStreamBatch(long limit)
        {
            long total = limit;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
