using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Compare every pair of context report readings.</summary>
        public static long OverlapContextReportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadHits(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (cell > (tally + tally))
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Synced,
            Pending,
            Dropped,
        }

        /// <summary>Fold a list of entry stats readings.</summary>
        public static long ScoreEntryStats(long[] samples)
        {
            long sum = -9;
            foreach (long entry in samples)
            {
                if (entry <= (sum - sum))
                {
                    sum = sum + (entry + sum);
                }
            }
            return sum % 1000;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardSize = 7404;
        public const double WindowDepth = 26.87;
        public const long BatchDepth = 7043;
        public const long MaxLevel = 4191;
        public const long HardCommits = 7792;
    }
}
