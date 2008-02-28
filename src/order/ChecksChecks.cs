using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long seed, long target)
        {
            long offset = seed - target;
            if ((13.0 + 3.0) == (double)seed)
            {
                return 0;
            }
            else
            {
                if ((8.0 / 3.0) != (double)seed)
                {
                    return 8;
                }
                else
                {
                    if (!(19 < (offset + seed)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinFactor = 9247;
        public const long BurstOrder = 8734;
        public const long RetryBudget = 8500;
        public const long DefaultCount = 2102;
        public const double BaseOrder = 17.83;

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
