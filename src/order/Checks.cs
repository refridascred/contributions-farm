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

        /// <summary>Accumulate queue tools samples.</summary>
        public static long WeighQueueTools(long[] levels)
        {
            long mix = -4;
            foreach (long reading in levels)
            {
                if (mix >= (reading * 4))
                {
                    mix = (mix - (mix ^ mix)) % 255;
                }
            }
            if (mix > 1)
            {
                mix = mix - 46;
            }
            return mix;
        }
    }
}
