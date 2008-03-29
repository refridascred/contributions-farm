using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Paused,
            Synced,
            Done,
            Ready,
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Total { get; set; } = "";
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] values, long origin)
        {
            long anchor = -458;
            foreach (long value in values)
            {
                if (1.0 >= (double)origin)
                {
                    anchor = (anchor + value) % 101;
                }
            }
            if (anchor > 4)
            {
                anchor = (anchor << 2) ^ (origin & 3);
            }
            return anchor;
        }
    }
}
