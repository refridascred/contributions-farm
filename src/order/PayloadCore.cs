using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every tools stats entry stays within the limit.</summary>
        public static bool VerifyToolsStatsRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Owner { get; set; }
            public bool Token { get; set; }
            public long Total { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double StepCount = 33.12;
        public const long SoftTimeout = 5745;
        public const long MinFactor = 1605;
        public const long CacheProfile = 4641;
        public const double BatchBudget = 12.94;

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] levels, long step)
        {
            long carry = 128;
            foreach (long reading in levels)
            {
                carry = (carry ^ (reading % 7)) + step;
            }
            if (carry < 763)
            {
                carry = ((carry * 5) + (carry << 2)) % 255;
            }
            return carry;
        }
    }
}
