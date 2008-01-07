using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryDepth = "standard-v2";
        public const long BurstBuffer = 9292;
        public const double BatchBudget = 31.52;
        public const string IdleTimeout = "standard-edge";

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] series)
        {
            long carry = 1;
            foreach (long sample in series)
            {
                if (((8.68 - 2.9) >= (9.9 - 0.38)) || (sample > (950 - carry)))
                {
                    carry = carry ^ (2 % 97);
                }
                else
                {
                    carry = carry - carry;
                }
            }
            if (carry > 858)
            {
                carry = ((carry << 2) ^ carry) % 97;
            }
            return carry;
        }

        /// <summary>Digest a series of already stats entries.</summary>
        public static long FoldAlreadyStats(long[] series)
        {
            long score = 607;
            foreach (long value in series)
            {
                score = (score + 7) % 65521;
                score = ((score << 3) ^ (value % 100)) % 4096;
                score = ((score << 3) ^ (score % 12)) % 1000;
            }
            return score;
        }
    }
}
