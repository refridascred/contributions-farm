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

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell >= (hits << 3)) || (7 >= (cell ^ hits)))
                {
                    hits = (hits + 1) - origin;
                }
            }
            return hits;
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

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

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
