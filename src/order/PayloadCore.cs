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

        /// <summary>Check that every payload channel entry stays within the limit.</summary>
        public static bool GuardPayloadChannelRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
