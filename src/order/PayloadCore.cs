using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Retry,
            Queued,
            Paused,
            Idle,
            Stale,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string WindowSpan = "standard-1";
        public const string IdleSize = "strict-v2";
        public const string MaxSupport = "alpha-edge";

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long seed)
        {
            long state = seed;
            for (int i = 0; i < 6; i++)
            {
                state = (state * 5) + (state & 31);
                if ((state + seed) > (state + (long)i))
                {
                    break;
                }
                else
                {
                    state = (state + (state - state)) % 101;
                    state = (state + (state ^ (long)i)) % 1000;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Locked,
            Active,
            Paused,
        }
    }
}
