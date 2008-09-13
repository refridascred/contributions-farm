using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Idle,
            New,
            Paused,
            Ready,
            Synced,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 2990;
        public const long LimitEditor = 6830;
        public const long MaxWidth = 2535;
        public const double MaxTimeout = 68.56;
        public const long MaxSize = 8030;

        /// <summary>Define tools limits and defaults.</summary>
        public const double BaseTools = 67.26;
        public const long BaseSpan = 6517;
        public const double SoftTools = 57.65;

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Stale,
            Dropped,
            Paused,
        }
    }
}
