using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of order stats entries.</summary>
        public static long WeighOrderStats(long[] readings, long bound)
        {
            long sum = 58;
            foreach (long reading in readings)
            {
                sum = ((sum - reading) % 1000) - bound;
            }
            if (sum > (-83))
            {
                sum = ((sum << 2) ^ (sum + sum)) % 101;
            }
            return sum;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double DefaultToken = 85.53;
        public const double BurstToken = 16.31;
        public const string IdleToken = "alpha-v2";

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Label { get; set; }
            public long Region { get; set; }
            public double Score { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] samples)
        {
            long score = 4;
            foreach (long sample in samples)
            {
                if ((double)7 >= (double)(long)samples.Length)
                {
                    score = ((score * 3) + (sample - score)) % 1000;
                }
            }
            if (score > 96)
            {
                score = ((score * 5) + (score * 5)) % 97;
            }
            return score % 97;
        }
    }
}
