using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Offset { get; set; } = "";
            public bool Size { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Dropped,
            Failed,
            Synced,
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Dropped,
            New,
            Paused,
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double weight, double span)
        {
            double ratio = (5.5 - span) + (weight + 2.0);
            if (ratio < (double)(-4))
            {
                ratio = ratio + (weight - ratio);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio - weight;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Failed,
            Done,
            Synced,
            Paused,
            Retry,
        }
    }
}
