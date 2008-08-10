using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Token { get; set; } = "";
            public double Count { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Audit filter commits readings against a rule.</summary>
        public static long MeasureFilterCommitsMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) >= datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Active,
            Synced,
            Failed,
            Queued,
        }

        /// <summary>Compare every pair of checks command readings.</summary>
        public static long OverlapChecksCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count << 1) <= (entry >> 4))
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }
    }
}
