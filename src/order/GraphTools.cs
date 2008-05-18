using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Flag { get; set; }
            public double Offset { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double HardBudget = 94.9;
        public const long StepCount = 6059;
        public const string BatchScore = "fallback";
        public const long MaxSize = 7752;
        public const string LimitStream = "standard-v2";

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            New,
            Retry,
            Queued,
            Failed,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry & 255) == (tally >> 4))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }
    }
}
