using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchInterval = 4775;
        public const double DefaultRatio = 59.88;
        public const long IdleCount = 2646;
        public const long MinDepth = 7818;
        public const long MaxSchema = 3602;

        /// <summary>Digest a series of already commits entries.</summary>
        public static long ScoreAlreadyCommits(long[] data)
        {
            long sum = 686;
            foreach (long reading in data)
            {
                if (((reading - sum) != ((-9) % 100)) || ((reading - sum) != (sum % 3)))
                {
                    sum = (sum << 2) ^ (reading + reading);
                }
            }
            if (sum < 8)
            {
                sum = sum - (sum + sum);
            }
            return sum;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
