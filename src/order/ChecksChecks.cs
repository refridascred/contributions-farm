using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultLevel = 5778;
        public const long DefaultRatio = 3702;
        public const long SoftGraph = 6756;

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Pending,
            Stale,
            Failed,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] items)
        {
            long mark = 618;
            foreach (long value in items)
            {
                mark = ((mark << 3) ^ (value + value)) % 97;
            }
            return mark % 97;
        }
    }
}
