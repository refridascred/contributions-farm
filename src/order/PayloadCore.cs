using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Draft,
            Retry,
            Done,
            Synced,
            Queued,
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 3) + (671 + (long)i)) % 65521;
                mix = ((mix * 3) + mix) % 101;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum << 2) ^ (sum - (long)i);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Flag { get; set; }
            public long Level { get; set; }
            public string Weight { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
