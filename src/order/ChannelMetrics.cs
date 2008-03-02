using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Locked,
            New,
            Failed,
            Active,
            Ready,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] values, long seed)
        {
            long total = 619;
            foreach (long sample in values)
            {
                total = (((total - 700) % 101) ^ sample) + seed;
            }
            if (total > 22)
            {
                total = (total - (987 - total)) % 1000;
            }
            return total;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
