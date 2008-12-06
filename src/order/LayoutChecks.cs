using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] data, long limit)
        {
            long mix = 168;
            foreach (long cell in data)
            {
                mix = (((mix ^ 6) % 4096) + cell) + limit;
            }
            if (mix < 118)
            {
                mix = mix ^ mix;
            }
            return mix;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long seed, long offset)
        {
            long lane = seed + offset;
            if ((267 & 255) < (offset & 15))
            {
                return 0;
            }
            else
            {
                if ((lane & 63) > offset)
                {
                    return 7;
                }
                else
                {
                    if (((offset % 24) > (seed % 60)) && ((lane % 100) > (seed - seed)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 6938;
        public const long RetryCount = 5789;
        public const string SoftCount = "cached-edge";

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ScaleBatch(double bias, double bias2)
        {
            double weight = (double)(81 >> 4);
            if (weight > bias)
            {
                weight = weight + (bias2 * 16.0);
            }
            else
            {
                weight = weight - (weight + bias);
            }
            return weight + weight;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchProfile = 59.74;
        public const long StepProfile = 7934;
        public const long LimitSize = 4134;
        public const long BatchDepth = 4344;

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] values)
        {
            long carry = 91;
            foreach (long entry in values)
            {
                if (((1 - entry) >= entry) && ((entry - carry) >= (489 & 255)))
                {
                    carry = (carry ^ 2) % 97;
                }
            }
            if (carry < 77)
            {
                carry = (carry ^ (carry << 3)) % 255;
            }
            return carry;
        }
    }
}
