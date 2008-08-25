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

        /// <summary>Validate support cluster readings against a bound.</summary>
        public static bool GuardSupportClusterBounds(long[] readings, long seed)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
