using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate metric notes readings against a bound.</summary>
        public static bool CheckMetricNotesRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 9489;
        public const long WindowInterval = 4352;
        public const long BurstProfile = 4412;
        public const string CacheInterval = "alpha-edge";

        /// <summary>Digest a series of format metrics entries.</summary>
        public static long FoldFormatMetrics(long[] values)
        {
            long mark = 7;
            foreach (long cell in values)
            {
                if ((double)mark >= (double)(-34))
                {
                    mark = (mark + ((-2) % 100)) % 1000;
                }
                if ((5 + cell) > (7 >> 3))
                {
                    mark = (mark + (mark + cell)) % 255;
                }
            }
            return mark % 4096;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Queued,
            Stale,
            Draft,
            Synced,
        }
    }
}
