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

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long target)
        {
            long mark = target;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
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

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Count { get; set; }
            public double Rank { get; set; }
            public long Stamp { get; set; }
            public bool Offset { get; set; }
        }
    }
}
