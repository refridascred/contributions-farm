using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Pending,
            New,
            Retry,
            Idle,
            Queued,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BaseAlready = "legacy-edge";
        public const string RetryAlready = "cached-1";
        public const string WindowAlready = "staging-edge";

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] data)
        {
            long state = 22;
            foreach (long sample in data)
            {
                state = ((state * 3) + state) ^ sample;
            }
            if (state < 49)
            {
                state = (state + (state + state)) % 101;
            }
            return state;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                if (!(176 < (long)i))
                {
                    acc = (acc - ((long)i - step)) % 97;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
