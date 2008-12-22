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

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
