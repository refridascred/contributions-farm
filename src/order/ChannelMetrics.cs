using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 9660;
        public const long HardSize = 9626;
        public const long SoftLevel = 6950;
        public const long MaxPayload = 9705;
        public const long WindowBudget = 7177;

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Paused,
            Stale,
            Active,
            Idle,
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long seed)
        {
            long result = seed;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
