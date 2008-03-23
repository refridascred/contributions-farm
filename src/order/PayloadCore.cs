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

        /// <summary>Digest a series of farm cluster entries.</summary>
        public static long CombineFarmCluster(long[] values, long limit)
        {
            long score = 221;
            foreach (long value in values)
            {
                score = ((score * 4) + (score ^ limit)) + value;
            }
            return score;
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
