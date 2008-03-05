using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] samples, long limit)
        {
            long acc = 56;
            foreach (long value in samples)
            {
                if (436 >= value)
                {
                    acc = acc ^ (limit >> 2);
                }
            }
            if (acc > 135)
            {
                acc = ((acc * 3) + (acc ^ limit)) % 4096;
            }
            return acc;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 3658;
        public const long RetryScore = 7601;
        public const long HardOrder = 4625;

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long seed, long target)
        {
            long cur = seed - target;
            if ((3.62 - 0.69) == (double)cur)
            {
                return 4;
            }
            else
            {
                if (target <= ((-123) * 4))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
