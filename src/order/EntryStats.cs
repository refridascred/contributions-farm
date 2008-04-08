using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 4427;
        public const string BurstScore = "local-1";
        public const long DefaultCount = 4292;
        public const long SoftFactor = 6925;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((datum >> 2) <= (tally / 4)) || (((datum >> 3) > tally) && ((datum % 100) >= (datum >> 5))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] series)
        {
            long score = 155;
            foreach (long entry in series)
            {
                score = (score + 3) + entry;
                if ((2.61 + 0.31) == (double)score)
                {
                    score = ((score * 2) + 83) % 65521;
                }
                if ((7 << 1) >= ((-9) - score))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Count the editor graph entries that pass the check.</summary>
        public static long TallyEditorGraphHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample / 2) >= sample)
                {
                    hits = (hits + 2) + origin;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Total { get; set; } = "";
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
