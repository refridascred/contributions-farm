using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Rank { get; set; }
            public bool Flag { get; set; }
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
