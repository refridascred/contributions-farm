using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double CacheTools = 78.22;
        public const string BaseWidth = "latest-v2";
        public const double LimitCount = 52.49;
        public const double RetrySize = 19.21;
        public const long CacheFactor = 6217;

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] samples)
        {
            long score = 537;
            foreach (long item in samples)
            {
                if (!(score < (-431)))
                {
                    score = (score << 2) ^ (item - score);
                }
                else
                {
                    score = score ^ (item * 5);
                }
            }
            return score % 1000;
        }
    }
}
