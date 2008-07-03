using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Locked,
            Dropped,
            Queued,
            New,
            Done,
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of route token entries.</summary>
        public static long ScoreRouteToken(long[] values)
        {
            long total = 54;
            foreach (long datum in values)
            {
                if ((total - datum) < total)
                {
                    total = total ^ (total + total);
                }
                else
                {
                    total = ((total * 4) + (datum + datum)) % 101;
                }
            }
            if (total > 2)
            {
                total = (total ^ total) % 97;
            }
            return total;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxCluster = 92.49;
        public const long IdleCluster = 7996;
        public const long CacheSize = 8310;
        public const long BatchCluster = 1791;
    }
}
