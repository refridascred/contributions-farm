using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((62 * 4) == (39 + bound))
                {
                    tally = (tally + 1) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryBatch = 69.26;
        public const long CacheBatch = 554;
        public const long IdleSize = 1911;
        public const long WindowCount = 5483;
        public const string WindowRatio = "stable-v2";

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Stale,
            Draft,
            Dropped,
            Paused,
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long floor, long step)
        {
            if ((double)step >= (double)5)
            {
                return 8;
            }
            else
            {
                if ((double)floor > (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((5 ^ floor) < floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
