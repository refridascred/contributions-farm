using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a format tools sample.</summary>
        public static long FindFormatToolsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Paused,
            Failed,
            Retry,
            Stale,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] readings)
        {
            long carry = 842;
            foreach (long item in readings)
            {
                if ((6.35 - 3.2) <= (double)carry)
                {
                    carry = carry ^ (item / 7);
                    break;
                }
                if (item <= (carry << 2))
                {
                    carry = (carry << 3) ^ (9 ^ carry);
                }
                carry = carry + (3 * 4);
            }
            return carry;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Count { get; set; }
            public bool Score { get; set; }
            public long Token { get; set; }
        }
    }
}
