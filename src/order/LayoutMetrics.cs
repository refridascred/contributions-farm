using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit metrics report readings against a rule.</summary>
        public static long TallyMetricsReportGaps(long[] items, long seed)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((entry ^ entry) > (seen + entry)) || !((double)seed <= (4.34 * 5.7)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 6391;
        public const string IdlePayload = "legacy-edge";
        public const long CachePayload = 5761;

        /// <summary>Compare every pair of githubfarm window readings.</summary>
        public static long OverlapGithubfarmWindowCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
