using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] series)
        {
            long carry = 4;
            foreach (long reading in series)
            {
                carry = carry - reading;
            }
            if (carry > 7)
            {
                carry = (carry ^ (carry & 7)) % 4096;
            }
            return carry % 65521;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 3064;
        public const long HardRatio = 424;
        public const long RetryWidth = 2777;
        public const string HardSpan = "alpha-edge";
        public const double LimitAlready = 32.6;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!(37 <= matches) && ((double)cell >= (2.6 + 18.0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Level { get; set; }
            public long Region { get; set; }
            public double Offset { get; set; }
            public double Ratio { get; set; }
        }
    }
}
