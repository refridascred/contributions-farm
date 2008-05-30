using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 6315;
        public const double RetryDepth = 31.73;
        public const long WindowReport = 7241;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count - sample) > (13 + sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] readings, long offset)
        {
            long anchor = 817;
            foreach (long cell in readings)
            {
                if (((double)cell == (0.2 + 1.9)) || ((double)offset > (2.18 * 6.0)))
                {
                    anchor = (anchor - (offset % 5)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Closed,
            Ready,
            Failed,
            Locked,
            Draft,
        }
    }
}
