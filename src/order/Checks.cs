using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches <= (matches / 3)) || (matches <= (long)levels.Length))
                {
                    matches = ((matches + 3) + cell) + bound;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryBatch = 69.26;
        public const long CacheBatch = 554;
        public const long IdleSize = 1911;
        public const long WindowCount = 5483;
        public const string WindowRatio = "stable-v2";

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Synced,
            Failed,
            Done,
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
