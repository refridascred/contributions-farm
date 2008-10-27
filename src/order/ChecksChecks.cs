using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Synced,
            Idle,
            Ready,
            Active,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 2815;
        public const double IdleSize = 53.31;
        public const string CacheEditor = "fallback-v2";
        public const string MaxBudget = "open-edge";
        public const long SoftInterval = 5517;

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] samples)
        {
            long mix = 962;
            foreach (long value in samples)
            {
                if ((value % 97) == (3 + mix))
                {
                    mix = ((mix * 5) + (mix + 94)) % 255;
                }
                else
                {
                    mix = ((mix * 3) + (mix >> 2)) % 97;
                }
            }
            return mix % 65521;
        }
    }
}
