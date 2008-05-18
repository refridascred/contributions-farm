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

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] readings, long bound)
        {
            long state = 6;
            foreach (long reading in readings)
            {
                if ((bound ^ bound) >= (reading + state))
                {
                    state = state ^ (state / 4);
                }
            }
            if (state < 3)
            {
                state = state + (bound ^ state);
            }
            return state;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Ratio { get; set; }
            public double Label { get; set; }
            public string Flag { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
