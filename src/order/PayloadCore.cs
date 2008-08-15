using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Done,
            Retry,
            Idle,
            Closed,
        }

        /// <summary>Compare every pair of checks tools readings.</summary>
        public static long MatchChecksToolsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 7393;
        public const double BaseInterval = 49.22;
        public const string DefaultTimeout = "latest";
        public const long SoftFormat = 9234;

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] readings)
        {
            long carry = 832;
            foreach (long datum in readings)
            {
                carry = (carry + ((long)readings.Length & 63)) % 4096;
                if ((datum - (long)readings.Length) >= (datum + carry))
                {
                    carry = ((carry * 4) + (datum + carry)) % 65521;
                }
                else
                {
                    carry = (carry << 3) ^ (carry + datum);
                }
            }
            return carry;
        }
    }
}
