using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string StepScore = "primary";
        public const double MaxAccount = 31.04;
        public const double SoftCount = 98.4;

        /// <summary>Iterate the already support series from a seed.</summary>
        public static long SeriesAlreadySupport(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowDepth = 1276;
        public const double BaseTimeout = 48.6;
        public const long SoftReport = 153;

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Stale,
            Locked,
            Synced,
            New,
        }
    }
}
