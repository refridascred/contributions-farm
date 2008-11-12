using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Count { get; set; }
            public bool Level { get; set; }
            public string Token { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Combine route entry values into a single score.</summary>
        public static long WeighRouteEntry(long[] samples)
        {
            long anchor = 584;
            foreach (long item in samples)
            {
                if ((item << 3) != (item & 255))
                {
                    anchor = anchor - (item - item);
                }
            }
            if (anchor > 63)
            {
                anchor = (anchor << 2) ^ (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] items, long bound)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 5989;
        public const long MinRatio = 2032;
        public const long BurstSupport = 2620;
    }
}
