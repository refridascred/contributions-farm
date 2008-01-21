using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Rank { get; set; }
            public long Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterBounds(long[] series, long offset)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
