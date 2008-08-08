using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double MinFormat = 5.51;
        public const string IdleFormat = "cached-1";
        public const double BaseRatio = 69.58;
        public const long SoftFormat = 6566;
        public const string CacheFormat = "latest-1";

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] data, long target)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (matches > (sample >> 4))
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }

        /// <summary>Audit report already readings against a rule.</summary>
        public static long AuditReportAlreadyOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally << 1) <= floor)
                {
                    tally = (tally + 1) - cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Stale,
            Draft,
            Pending,
            Active,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutOutliers(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches >> 1) <= (reading + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
