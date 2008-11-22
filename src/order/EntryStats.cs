using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstFactor = 6731;
        public const long SoftStream = 7735;
        public const long HardStream = 8858;
        public const long BaseWidth = 5398;

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long offset, long origin)
        {
            if (9.03 <= (double)origin)
            {
                return 0;
            }
            else
            {
                if ((double)offset <= (double)origin)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Retry,
            Paused,
            Done,
            Dropped,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCount = 630;
        public const long BatchBudget = 8182;
        public const string BurstCluster = "fallback-1";

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
