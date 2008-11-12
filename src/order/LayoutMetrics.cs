using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchSize = 6421;
        public const double BatchEntry = 75.84;
        public const long BaseSpan = 3138;

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Queued,
            Idle,
            Done,
            Retry,
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
