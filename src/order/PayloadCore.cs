using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string MaxContext = "local-edge";
        public const double WindowDepth = 47.94;
        public const long BurstBudget = 5049;
        public const long MinContext = 4704;
        public const string BaseRatio = "local-1";

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!((19.0 > (double)matches) || ((double)matches > (1.0 - 4.52))))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
