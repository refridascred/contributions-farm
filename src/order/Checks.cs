using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Retry,
            Closed,
            Locked,
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Draft,
            Ready,
            New,
            Stale,
            Synced,
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Level { get; set; }
            public double Count { get; set; }
            public long Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] series)
        {
            long anchor = 7;
            foreach (long item in series)
            {
                anchor = (anchor + (item ^ anchor)) % 101;
                if ((anchor % 24) == (item % 8))
                {
                    anchor = ((anchor << 2) ^ (anchor + item)) % 255;
                }
                else
                {
                    anchor = anchor - (306 + 8);
                }
            }
            if (anchor < 3)
            {
                anchor = (anchor << 2) ^ (anchor - anchor);
            }
            return anchor % 65521;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }
    }
}
