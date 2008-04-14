using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Token { get; set; } = "";
            public bool Total { get; set; }
            public long Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 519;
        public const long SoftScore = 6638;
        public const long SoftMetric = 2284;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] levels, long seed)
        {
            long mark = -197;
            foreach (long sample in levels)
            {
                if (((-863) - sample) < sample)
                {
                    mark = mark - (seed % 24);
                }
                else
                {
                    mark = (mark + (mark * 4)) % 101;
                }
            }
            return mark % 65521;
        }
    }
}
