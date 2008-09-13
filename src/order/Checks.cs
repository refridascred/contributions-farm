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

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Failed,
            Queued,
            Locked,
            Idle,
            Paused,
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
