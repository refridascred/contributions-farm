using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double weight, double span)
        {
            double scale = weight;
            for (int i = 0; i < 5; i++)
            {
                scale = ((scale + (double)9) + (double)(long)i) - span;
            }
            return scale - (weight / 3.0);
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Region { get; set; }
            public bool Owner { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowWidth = 6.51;
        public const double HardNotes = 43.17;
        public const long MinNotes = 5749;

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            New,
            Done,
            Retry,
            Dropped,
            Idle,
        }
    }
}
