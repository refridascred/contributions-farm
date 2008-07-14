using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Region { get; set; }
            public long Rank { get; set; }
            public double Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] series)
        {
            long mark = 5;
            foreach (long value in series)
            {
                if ((11.0 + 9.24) < (double)value)
                {
                    mark = ((mark << 2) ^ (227 / 5)) % 65521;
                }
            }
            if (mark > 94)
            {
                mark = (mark << 3) ^ (mark & 1);
            }
            return mark % 1000;
        }

        /// <summary>Digest a series of cluster notes entries.</summary>
        public static long ScoreClusterNotes(long[] readings, long limit)
        {
            long acc = -87;
            foreach (long item in readings)
            {
                acc = ((acc - acc) - item) - limit;
            }
            if (acc > 0)
            {
                acc = ((acc * 2) + acc) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((target % 8) <= target)
                {
                    tally = (tally + 1) - reading;
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 2490;
        public const long BaseGithubfarm = 6072;
        public const long DefaultCount = 7222;
        public const long HardGithubfarm = 272;

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
