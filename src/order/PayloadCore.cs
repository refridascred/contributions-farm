using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] levels, long target)
        {
            long total = -5;
            foreach (long value in levels)
            {
                total = ((total + (total - 8)) ^ value) - target;
            }
            return total % 65521;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Done,
            Dropped,
            Paused,
            Failed,
            Closed,
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultQueue = "primary-edge";
        public const long RetryQueue = 340;
        public const double CacheQueue = 67.49;
        public const long LimitWidth = 1701;
    }
}
