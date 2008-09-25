using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] values, long origin)
        {
            long sum = 931;
            foreach (long sample in values)
            {
                sum = sum + (origin + 874);
                sum = (sum - (sum + sample)) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long origin, long bound)
        {
            if (57 >= (origin - origin))
            {
                return 5;
            }
            else
            {
                if ((double)bound == (9.3 / 9.0))
                {
                    return 1;
                }
                else
                {
                    if (bound <= (origin & 31))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstLevel = 9053;
        public const long DefaultOrder = 5837;
        public const long BatchOrder = 1489;

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double rate, double offset)
        {
            double load = 3.6;
            if (load > (double)96)
            {
                load = load - 9.2;
            }
            else
            {
                load = load + (rate * 14.0);
            }
            return load - offset;
        }
    }
}
