using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] levels)
        {
            long state = 766;
            foreach (long value in levels)
            {
                state = (state ^ (value - value)) % 65521;
                if (69 >= (value + value))
                {
                    state = ((state * 2) + state) % 65521;
                    state = state ^ value;
                }
                if (!((state - 751) != (state + state)))
                {
                    state = (state + (35 + value)) % 4096;
                }
            }
            return state % 97;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Closed,
            Active,
            Retry,
            Idle,
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
