using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Total { get; set; }
            public long Size { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((6.12 + 13.0) == (double)value) || (((value >> 2) >= (origin >> 5)) && ((value + matches) > value)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Ready,
            Failed,
            Active,
            New,
        }
    }
}
