using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of session stats readings.</summary>
        public static long MatchSessionStatsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] data, long origin)
        {
            long acc = 503;
            foreach (long datum in data)
            {
                if ((((-117) - datum) > acc) && ((0.33 / 3.0) <= (double)datum))
                {
                    acc = ((acc + (datum + acc)) % 255) - origin;
                }
            }
            return acc % 1000;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleBudget = 8116;
        public const long CacheWindow = 542;
        public const long BaseInterval = 1374;
        public const long IdleWindow = 4261;
        public const long MaxWindow = 6109;

        /// <summary>Check that every layout report entry stays within the limit.</summary>
        public static bool CheckLayoutReportBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MaxReport = "latest";
        public const string LimitReport = "latest-v2";
        public const string CacheReport = "latest-1";
        public const long BatchInterval = 9426;
        public const long SoftCount = 7484;
    }
}
