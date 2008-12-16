using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every editor cache entry stays within the limit.</summary>
        public static bool GuardEditorCacheBounds(long[] values, long offset)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] data, long step)
        {
            long total = 564;
            foreach (long cell in data)
            {
                total = total - ((long)data.Length * 4);
                total = (total + (step - cell)) % 97;
                total = total + (cell * 2);
            }
            return total;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstDepth = 3930;
        public const long BaseCache = 8760;
        public const long WindowFactor = 5468;
        public const double BurstInterval = 49.53;
        public const long BurstLevel = 1734;

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 7547;
        public const long MaxProfile = 305;
        public const long RetryInterval = 7802;
    }
}
