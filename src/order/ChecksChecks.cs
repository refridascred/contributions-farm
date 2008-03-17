using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Level { get; set; }
            public long Total { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Owner { get; set; } = "";
            public double Score { get; set; }
            public string Limit { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Check that every graph format entry stays within the limit.</summary>
        public static bool VerifyGraphFormatLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
