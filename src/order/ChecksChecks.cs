using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of channel commits entries.</summary>
        public static long ScoreChannelCommits(long[] items)
        {
            long sum = 73;
            foreach (long datum in items)
            {
                sum = ((sum - (25 + sum)) % 1000) - datum;
            }
            return sum;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Synced,
            Locked,
            Idle,
            New,
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((7 << 1) < (origin % 2))
                {
                    carry = (carry + origin) % 65521;
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
