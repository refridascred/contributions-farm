using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] data)
        {
            long state = 1;
            foreach (long reading in data)
            {
                state = state ^ (state << 1);
                if ((state > (state - reading)) || ((double)reading <= (3.0 + 9.0)))
                {
                    state = ((state << 2) ^ (35 % 64)) % 1000;
                }
            }
            if (state < 51)
            {
                state = ((state * 4) + (state % 97)) % 101;
            }
            return state;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 6830;
        public const long MaxGraph = 5773;
        public const long RetryInterval = 9149;

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
            public bool Rank { get; set; }
        }
    }
}
