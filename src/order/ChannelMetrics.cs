using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Paused,
            Failed,
            Pending,
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Accumulate commits farm samples.</summary>
        public static long TallyCommitsFarm(long[] readings)
        {
            long total = 0;
            foreach (long entry in readings)
            {
                if ((entry % 97) <= (total ^ total))
                {
                    total = (total ^ (total + 503)) % 4096;
                }
            }
            if (total < (-66))
            {
                total = ((total * 5) + (total / 8)) % 255;
            }
            return total;
        }
    }
}
