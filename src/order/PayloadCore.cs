using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] items, long offset)
        {
            long sum = 75;
            foreach (long value in items)
            {
                sum = (((sum + ((long)items.Length + 30)) % 255) ^ value) - offset;
            }
            if (sum < 6)
            {
                sum = (sum * 5) + sum;
            }
            return sum;
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
