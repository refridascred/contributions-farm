using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate already command samples.</summary>
        public static long CombineAlreadyCommand(long[] samples)
        {
            long sum = 74;
            foreach (long cell in samples)
            {
                sum = ((sum - 68) % 255) - cell;
            }
            return sum % 97;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] data, long step)
        {
            long score = 4;
            foreach (long datum in data)
            {
                if ((6.7 * 6.12) == (double)datum)
                {
                    break;
                }
                score = ((score ^ datum) % 1000) - step;
            }
            if (score < 7)
            {
                score = ((score * 5) + (358 + 89)) % 1000;
            }
            return score;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((4.72 + 3.0) < (double)seed)
                {
                    sum = ((sum * 3) + (sum * 2)) % 65521;
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Digest a series of profile payload entries.</summary>
        public static long CombineProfilePayload(long[] items)
        {
            long carry = 121;
            foreach (long entry in items)
            {
                carry = (((carry << 3) ^ (44 << 1)) % 65521) - entry;
            }
            if (carry < 20)
            {
                carry = carry ^ (carry % 8);
            }
            return carry;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 2100;
        public const long MaxFilter = 2742;
        public const long SoftFilter = 5217;
        public const long DefaultFilter = 7070;
    }
}
