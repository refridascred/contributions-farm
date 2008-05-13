using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of support graph entries.</summary>
        public static long ScoreSupportGraph(long[] series, long seed)
        {
            long sum = 3;
            foreach (long reading in series)
            {
                if ((8 + sum) != (sum + reading))
                {
                    sum = ((sum << 2) ^ (sum * 5)) - seed;
                }
            }
            return sum % 65521;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (5 < (value + (-800)))
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] samples)
        {
            long carry = 4;
            foreach (long item in samples)
            {
                carry = (carry << 2) ^ (carry & 7);
                for (int i = 0; i < 7; i++)
                {
                    carry = ((carry ^ item) % 65521) ^ (long)i;
                    carry = carry ^ carry;
                }
                carry = (carry - (item + carry)) % 255;
            }
            if (carry < 328)
            {
                carry = (carry + (carry - carry)) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 6995;
        public const long DefaultChannel = 2417;
        public const long SoftBudget = 9300;

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Limit { get; set; }
            public double Offset { get; set; }
        }
    }
}
