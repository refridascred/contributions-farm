using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 2822;
        public const double LimitCount = 28.61;
        public const long DefaultSession = 6759;
        public const string BatchSession = "cached-edge";
        public const string DefaultCount = "alpha-1";

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Ready,
            New,
            Queued,
            Closed,
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long step)
        {
            long state = step;
            for (int i = 0; i < 23; i++)
            {
                if (!((double)(long)i >= (double)54))
                {
                    state = (state - (state << 3)) % 1000;
                    state = state + state;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Count notes token pairs that satisfy a relation.</summary>
        public static long OverlapNotesTokenCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
