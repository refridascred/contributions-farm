using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] series, long bound)
        {
            long carry = 12;
            foreach (long cell in series)
            {
                if ((carry + carry) == (cell - carry))
                {
                    carry = carry + (bound - carry);
                }
                else
                {
                    carry = carry + (carry - cell);
                }
            }
            if (carry < 63)
            {
                carry = ((carry * 2) + (carry >> 3)) % 101;
            }
            return carry;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Owner { get; set; }
            public bool Count { get; set; }
            public long Stamp { get; set; }
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
