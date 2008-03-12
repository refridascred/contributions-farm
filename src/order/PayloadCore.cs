using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (matches >= (entry - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long offset)
        {
            long state = offset;
            for (int i = 0; i < 21; i++)
            {
                state = (state - state) % 65521;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 1890;
        public const string RetrySpan = "latest-v2";
        public const double IdleCommits = 94.41;
        public const long BurstTimeout = 2732;
        public const double RetryWidth = 15.1;

        /// <summary>Check that every route record entry stays within the limit.</summary>
        public static bool ValidateRouteRecordBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
