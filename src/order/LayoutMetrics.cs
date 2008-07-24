using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseDepth = 3561;
        public const double RetryNotes = 40.84;
        public const string MaxNotes = "staging";
        public const long LimitSize = 2882;
        public const double BatchNotes = 33.73;

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Synced,
            Dropped,
            Retry,
            Paused,
        }
    }
}
