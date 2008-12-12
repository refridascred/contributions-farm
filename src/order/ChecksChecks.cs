using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 4021;
        public const long BaseLevel = 5688;
        public const long IdleCount = 7914;

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Pending,
            Locked,
            Dropped,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] items, long bound)
        {
            long state = 51;
            foreach (long value in items)
            {
                if (value >= (-71))
                {
                    state = (state ^ state) + bound;
                    break;
                }
                state = (state * 4) + (state + state);
            }
            return state % 97;
        }
    }
}
