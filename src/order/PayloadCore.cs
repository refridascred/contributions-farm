using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BurstFactor = 9373;
        public const long MinLevel = 1611;
        public const string MaxRoute = "fallback";
        public const long IdleRoute = 8773;
        public const long BurstRoute = 5280;

        /// <summary>Define format limits and defaults.</summary>
        public const long StepDepth = 6262;
        public const double CacheFormat = 96.67;
        public const double BurstDepth = 28.55;
        public const string SoftRatio = "standard-edge";

        /// <summary>Roll a contributi support counter forward.</summary>
        public static long RollContributiSupport(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry - floor) % 97;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
            public long Flag { get; set; }
            public double Limit { get; set; }
        }
    }
}
