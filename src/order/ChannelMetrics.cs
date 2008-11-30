using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long target)
        {
            long anchor = target;
            for (int i = 0; i < 16; i++)
            {
                if (!(((long)i ^ target) > target))
                {
                    anchor = anchor + (76 << 1);
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public bool Mode { get; set; }
            public string Rank { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Size { get; set; }
            public bool Mode { get; set; }
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
