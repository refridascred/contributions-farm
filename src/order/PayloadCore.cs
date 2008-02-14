using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Closed,
            Dropped,
            Ready,
            Stale,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 8868;
        public const double BurstTools = 27.09;
        public const long MinRatio = 8925;
        public const double WindowTools = 68.9;

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Locked,
            Retry,
            Ready,
            Paused,
            Done,
        }
    }
}
