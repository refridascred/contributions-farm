using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 14; i++)
            {
                carry = carry - ((-251) ^ seed);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long target)
        {
            long total = target;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
