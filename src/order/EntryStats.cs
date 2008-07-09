using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            New,
            Pending,
            Failed,
            Idle,
            Synced,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 6849;
        public const double MaxPayload = 28.54;
        public const string MaxScore = "alpha-edge";

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((0.7 - 6.85) != (double)entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Pending,
            Synced,
            Failed,
            Locked,
            Stale,
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long offset)
        {
            long score = offset;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = ((score * 4) + (offset >> 3)) - (long)i2;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
