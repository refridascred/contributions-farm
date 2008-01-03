using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a order checks reading by value.</summary>
        public static long LocateOrderChecksIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry context values into a single score.</summary>
        public static long WeighEntryContext(long[] values)
        {
            long sum = 518;
            foreach (long sample in values)
            {
                sum = (sum - (-97)) ^ sample;
            }
            if (sum > (-715))
            {
                sum = (sum * 2) + (13 - sum);
            }
            return sum % 4096;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public string Mode { get; set; } = "";
            public double Score { get; set; }
        }
    }
}
