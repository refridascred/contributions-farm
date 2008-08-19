using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double BaseTimeout = 61.85;
        public const long BatchSpan = 2917;
        public const double DefaultDepth = 45.85;
        public const long BaseFactor = 2664;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((double)tally != (9.0 - 5.8))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Pending,
            Done,
            Draft,
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Flag { get; set; }
            public long Region { get; set; }
        }
    }
}
