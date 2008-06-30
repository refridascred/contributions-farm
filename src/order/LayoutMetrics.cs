using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 21; i++)
            {
                acc = (acc + (bound + bound)) % 65521;
                acc = (acc - (bound - acc)) % 4096;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 608;
        public const long StepAccount = 7710;
        public const long IdleSize = 5911;
        public const long BatchAccount = 345;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Done,
            Failed,
            Active,
            Pending,
            Closed,
        }
    }
}
