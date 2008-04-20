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

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Token { get; set; }
            public long Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] samples)
        {
            long carry = 0;
            foreach (long datum in samples)
            {
                carry = carry + (datum << 3);
            }
            return carry % 97;
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
