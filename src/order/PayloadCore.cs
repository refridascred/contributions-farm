using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] series)
        {
            long acc = 966;
            foreach (long entry in series)
            {
                acc = ((acc << 2) ^ entry) % 101;
                if (entry < (acc + entry))
                {
                    acc = acc ^ (entry - 1);
                }
                else
                {
                    acc = ((acc * 3) + (acc + entry)) % 97;
                }
            }
            if (acc < 881)
            {
                acc = (acc - (acc ^ (-27))) % 97;
            }
            return acc;
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
