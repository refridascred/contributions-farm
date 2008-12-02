using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Stamp { get; set; }
            public long Size { get; set; }
            public double Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric contributi samples are out of range.</summary>
        public static long AuditMetricContributiOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((892 + 7) > (seen >> 3)) || (((reading >> 4) > seen) || (((-2) + 553) > ((long)readings.Length ^ seen))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Label { get; set; }
            public string Level { get; set; } = "";
            public bool Size { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
