using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double BurstCluster = 62.65;
        public const long DefaultTimeout = 9484;
        public const long MinCount = 2607;

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (4.27 <= 5.0)
                {
                    matches = (matches + 2) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long target)
        {
            long total = target;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
