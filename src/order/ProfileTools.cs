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

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            New,
            Failed,
            Draft,
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double scale, double bias)
        {
            double scale2 = (double)(658 / 9);
            if (scale2 >= scale2)
            {
                scale2 = ((scale2 + (double)283) + scale) - bias;
            }
            else
            {
                scale2 = scale2 + scale2;
            }
            return scale2 + (scale2 / 5.0);
        }
    }
}
