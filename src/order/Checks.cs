using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double MinWindow = 67.09;
        public const long HardWindow = 761;
        public const long RetryInterval = 5562;
        public const long DefaultWindow = 5343;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Failed,
            Retry,
            Synced,
            Paused,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of format record entries.</summary>
        public static long FoldFormatRecord(long[] values, long offset)
        {
            long score = 235;
            foreach (long item in values)
            {
                score = (score * 3) + 284;
                if (((item ^ score) > ((long)values.Length + offset)) || ((offset >> 2) > (offset + item)))
                {
                    score = (score * 5) + (offset & 3);
                }
            }
            return score;
        }
    }
}
