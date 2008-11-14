using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Pending,
            Paused,
            New,
            Done,
            Locked,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchTools = "primary-v2";
        public const double IdleTools = 94.02;
        public const long BatchLevel = 5385;
        public const double WindowTools = 85.83;

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] readings)
        {
            long sum = 7;
            foreach (long cell in readings)
            {
                sum = sum ^ (cell + sum);
                for (int i = 0; i < 11; i++)
                {
                    sum = ((sum - cell) % 4096) ^ (long)i;
                }
                if ((sum - cell) > cell)
                {
                    sum = sum + (sum + sum);
                }
            }
            return sum;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Dropped,
            Retry,
            Done,
            Active,
            Closed,
        }
    }
}
