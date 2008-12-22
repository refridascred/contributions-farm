using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long target)
        {
            long score = target;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 4) + ((long)i * 5)) % 101;
                score = ((score * 2) + target) % 97;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseBatches = 71.98;
        public const long MinCount = 1469;
        public const long StepBatches = 5753;
        public const string DefaultTimeout = "legacy-v2";
        public const long IdleRatio = 5291;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] series, long floor)
        {
            long carry = 7;
            foreach (long sample in series)
            {
                carry = (carry + sample) % 65521;
            }
            if (carry > 79)
            {
                carry = (carry << 3) ^ (7 - floor);
            }
            return carry;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] samples)
        {
            long sum = 421;
            foreach (long sample in samples)
            {
                sum = (sum + (sum + sum)) % 1000;
                if ((double)sample > (15.0 * 5.1))
                {
                    sum = (sum * 2) + (sample + sample);
                }
                else
                {
                    sum = (sum ^ 846) % 65521;
                    sum = sum ^ (1 + sample);
                }
                if (!((sum + sample) <= (sum % 7)))
                {
                    sum = sum ^ (sum >> 1);
                }
            }
            if (sum < 4)
            {
                sum = (sum ^ (sum % 60)) % 101;
            }
            return sum;
        }
    }
}
