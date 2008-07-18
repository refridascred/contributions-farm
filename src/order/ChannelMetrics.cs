using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every githubfarm editor entry stays within the limit.</summary>
        public static bool VerifyGithubfarmEditorBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Weight { get; set; }
            public double Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Size { get; set; }
            public string Flag { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
