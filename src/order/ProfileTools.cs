using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 1793;
        public const long MinTimeout = 4875;
        public const double MaxTimeout = 83.67;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Failed,
            Locked,
            Active,
            Idle,
            Done,
        }

        /// <summary>Match up checks token samples.</summary>
        public static long PairChecksTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!((double)4 == (double)sample) || (count >= sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double bias, double floor)
        {
            double drift = (double)(59 / 7);
            if (drift >= floor)
            {
                drift = (drift + drift) - bias;
            }
            return drift - drift;
        }
    }
}
