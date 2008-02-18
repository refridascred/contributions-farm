using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Score { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Count { get; set; }
            public string Total { get; set; } = "";
            public string Mode { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
