using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long target)
        {
            long total = target;
            for (int i = 0; i < 22; i++)
            {
                total = (total - (total + target)) % 4096;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            New,
            Paused,
            Active,
            Idle,
            Draft,
        }
    }
}
