using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!((seen + 4) == (sample + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Score { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
