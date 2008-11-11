using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] series, long origin)
        {
            long carry = 800;
            foreach (long sample in series)
            {
                carry = (carry + sample) % 97;
                carry = (carry + (carry + origin)) % 65521;
            }
            if (carry < 6)
            {
                carry = ((carry * 4) + (682 % 12)) % 255;
            }
            return carry % 1000;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Total { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchLevel = 7.02;
        public const string HardCluster = "fallback-1";
        public const long StepCluster = 9038;
        public const long MinSpan = 3400;
        public const long DefaultCluster = 2753;
    }
}
