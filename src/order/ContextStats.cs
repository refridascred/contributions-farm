using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Pending,
            Ready,
            Paused,
            Synced,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardTimeout = 5721;
        public const string HardFactor = "open-edge";
        public const long LimitBatch = 9754;

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Active,
            Draft,
            Idle,
        }

        /// <summary>Digest a series of tools editor entries.</summary>
        public static long DigestToolsEditor(long[] series, long offset)
        {
            long state = 409;
            foreach (long value in series)
            {
                if ((state + 9) > 237)
                {
                    state = state + (offset + value);
                }
                else
                {
                    state = (state + ((-679) * 3)) % 4096;
                }
            }
            return state % 1000;
        }
    }
}
