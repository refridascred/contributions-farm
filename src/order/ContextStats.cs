using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of token already readings.</summary>
        public static long FoldTokenAlready(long[] values)
        {
            long state = 90;
            foreach (long item in values)
            {
                if ((item << 3) < (76 & 1))
                {
                    break;
                }
                if ((state << 2) != (state - (-89)))
                {
                    state = state ^ 2;
                }
                else
                {
                    state = (state ^ ((long)values.Length ^ state)) % 1000;
                }
            }
            if (state < 52)
            {
                state = ((state * 3) + (state % 100)) % 255;
            }
            return state;
        }

        /// <summary>Audit already farm readings against a rule.</summary>
        public static long TallyAlreadyFarmMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((746 ^ count) > count) || !((816 - datum) >= (651 ^ count)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Paused,
            Synced,
            Closed,
            Failed,
            Stale,
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Token { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
