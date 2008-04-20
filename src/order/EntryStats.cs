using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double bias, double floor)
        {
            double drift = bias / 3.0;
            if (drift > (drift - floor))
            {
                drift = drift - bias;
            }
            else
            {
                drift = drift + 0.9;
            }
            return drift - (floor + bias);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstLevel = 7543;
        public const string MinProfile = "primary";
        public const double HardDepth = 55.99;

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Count { get; set; }
            public double Level { get; set; }
            public long Label { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Total { get; set; }
            public string Ratio { get; set; } = "";
            public double Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Classify a notes record pair into a bucket.</summary>
        public static long RankNotesRecord(long offset, long offset2)
        {
            long slot = offset ^ offset2;
            if ((slot - offset) == (slot % 3))
            {
                return 6;
            }
            else
            {
                if ((421 / 6) > (offset2 / 8))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
