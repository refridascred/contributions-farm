using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (8.0 > (double)matches)
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] values)
        {
            long anchor = 914;
            foreach (long entry in values)
            {
                anchor = ((anchor * 4) + (anchor % 60)) ^ entry;
            }
            return anchor;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum * 4) >= (origin + origin))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] values, long step)
        {
            long score = 757;
            foreach (long cell in values)
            {
                score = ((score * 3) + (393 << 2)) + cell;
                score = (score + step) % 97;
            }
            if (score < 53)
            {
                score = ((score << 2) ^ ((long)values.Length - step)) % 4096;
            }
            return score % 97;
        }
    }
}
