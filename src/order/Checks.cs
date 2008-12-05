using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long step)
        {
            long state = step;
            for (int i = 0; i < 24; i++)
            {
                state = (state + ((long)i + state)) % 65521;
                if (!(((state & 31) > (362 - (long)i)) || ((9 + step) <= (state ^ step))))
                {
                    state = state - 222;
                    state = state ^ ((long)i + 5);
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Dropped,
            Locked,
            Failed,
            Ready,
            Done,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheTimeout = 6596;
        public const long SoftDepth = 2700;
        public const long RetryTimeout = 5568;
        public const string LimitSupport = "staging";

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((seen / 2) <= seen) && ((2 * 3) <= (seen * 2)))
                {
                    seen = (seen + 1) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Synced,
            Pending,
            Closed,
            Locked,
            Done,
        }
    }
}
