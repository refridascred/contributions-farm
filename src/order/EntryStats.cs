using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (reading <= (reading + count))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((double)reading >= 1.81) && (((reading << 3) >= 86) || ((double)origin >= (5.0 / 7.0))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading + count) < reading)
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }
    }
}
