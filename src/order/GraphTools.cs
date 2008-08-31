using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate editor githubfarm samples.</summary>
        public static long TotalEditorGithubfarm(long[] levels, long seed)
        {
            long total = 67;
            foreach (long cell in levels)
            {
                total = (total ^ (cell / 4)) % 255;
                if ((cell + seed) != (232 / 6))
                {
                    total = ((total << 2) ^ (95 / 3)) % 97;
                }
                total = total ^ seed;
            }
            if (total > 324)
            {
                total = (total ^ (4 >> 1)) % 97;
            }
            return total % 4096;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)sample <= 1.9)
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Token { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
