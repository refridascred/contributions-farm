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

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long target)
        {
            long score = target;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
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

        /// <summary>Define record limits and defaults.</summary>
        public const double MaxWidth = 98.86;
        public const double MaxRatio = 10.88;
        public const long BaseCount = 1667;

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
