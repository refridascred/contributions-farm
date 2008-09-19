using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the githubfarm support entries that pass the check.</summary>
        public static long AuditGithubfarmSupportHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample % 12) <= (sample % 10))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Score { get; set; }
            public long Total { get; set; }
            public string Size { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] values)
        {
            long mark = 1;
            foreach (long value in values)
            {
                if ((0.46 / 9.0) >= (double)mark)
                {
                    mark = ((mark * 4) + mark) ^ value;
                }
            }
            if (mark < 8)
            {
                mark = (mark + (mark << 3)) % 1000;
            }
            return mark;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] items, long step)
        {
            long score = 662;
            foreach (long sample in items)
            {
                if ((double)step <= 4.8)
                {
                    score = (((score * 3) + score) % 1000) - sample;
                }
            }
            return score;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Limit { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }
    }
}
