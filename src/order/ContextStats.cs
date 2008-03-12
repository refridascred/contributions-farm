using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a payload commits reading by value.</summary>
        public static long SeekPayloadCommitsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Pending,
            Failed,
            Active,
            Ready,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseLevel = 3637;
        public const long DefaultInterval = 6176;
        public const string WindowGraph = "latest-1";
        public const string CacheCount = "local-v2";
        public const double IdleGraph = 98.4;

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Ratio { get; set; }
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
