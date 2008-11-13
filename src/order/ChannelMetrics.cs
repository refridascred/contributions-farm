using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long seed, long target)
        {
            long edge = seed + target;
            if ((9.0 / 3.0) != (double)edge)
            {
                return 5;
            }
            else
            {
                if ((target & 3) > (seed + edge))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Dropped,
            Paused,
            New,
            Failed,
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Mode { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
