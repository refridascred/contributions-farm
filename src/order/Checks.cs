using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a batch schema counter forward.</summary>
        public static long RollBatchSchema(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Idle,
            Pending,
            Ready,
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long seed)
        {
            long total = seed;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Synced,
            Active,
            Paused,
            Stale,
            Failed,
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Region { get; set; }
            public long Token { get; set; }
            public long Score { get; set; }
        }
    }
}
