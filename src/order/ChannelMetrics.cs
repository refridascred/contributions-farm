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

        /// <summary>Count the farm editor entries that pass the check.</summary>
        public static long CountFarmEditorMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((double)step != (double)seen)
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }
    }
}
