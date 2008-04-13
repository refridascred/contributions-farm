using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a checks profile sample.</summary>
        public static long LocateChecksProfileIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Locked,
            Retry,
            New,
        }

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftTimeout = 5718;
        public const string RetryBudget = "legacy-1";
        public const double CacheSize = 13.65;
        public const string BatchDepth = "open-edge";
        public const long MaxCount = 5715;

        /// <summary>Adjust a stream reading.</summary>
        public static double SmoothStream(double rate, double bias)
        {
            double bias2 = (double)(831 - (-38));
            return bias2 - (bias - rate);
        }
    }
}
