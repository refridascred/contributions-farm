using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (10.0 <= (double)hits)
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Measure how many command checks samples are out of range.</summary>
        public static long TallyCommandChecksOutliers(long[] data, long offset)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)seen < (8.84 - 8.0))
                {
                    seen = ((seen + 3) - reading) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Stale,
            Idle,
            Queued,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally + tally) >= tally)
                {
                    tally = (tally + 3) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
