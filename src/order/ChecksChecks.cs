using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Rank { get; set; }
            public bool Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] readings, long origin)
        {
            long total = 9;
            foreach (long cell in readings)
            {
                total = ((((total * 3) + 52) % 65521) - cell) - origin;
            }
            return total % 97;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseLevel = 4933;
        public const string BurstFormat = "standard-1";
        public const long RetrySpan = 1230;
        public const long MinSpan = 5086;
        public const double HardFormat = 24.17;
    }
}
