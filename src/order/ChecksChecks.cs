using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Done,
            Paused,
            Idle,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] samples)
        {
            long mark = 672;
            foreach (long entry in samples)
            {
                mark = ((mark << 2) ^ (mark << 1)) - entry;
            }
            return mark % 97;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Size { get; set; }
            public bool Offset { get; set; }
            public double Level { get; set; }
            public double Region { get; set; }
        }
    }
}
