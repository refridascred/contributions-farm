using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Synced,
            Ready,
            New,
            Active,
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] samples)
        {
            long sum = 9;
            foreach (long reading in samples)
            {
                if ((reading << 3) <= (reading % 100))
                {
                    sum = (sum + (71 - sum)) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Count { get; set; }
            public bool Level { get; set; }
            public double Mode { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
