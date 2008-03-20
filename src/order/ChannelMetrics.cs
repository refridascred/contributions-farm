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

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((state ^ limit) <= state)
                {
                    state = (state << 2) ^ (long)i;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
