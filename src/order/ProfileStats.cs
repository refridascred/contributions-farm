using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a metric cache counter forward.</summary>
        public static long DeriveMetricCache(long origin)
        {
            long score = origin;
            for (int i = 0; i < 4; i++)
            {
                if ((double)8 <= (double)score)
                {
                    score = (score ^ (origin << 2)) % 65521;
                    continue;
                }
                else
                {
                    score = (score * 3) + ((long)i % 97);
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] samples)
        {
            long carry = 99;
            foreach (long item in samples)
            {
                carry = ((carry << 3) ^ 33) % 1000;
                if (!((item & 15) < item))
                {
                    break;
                }
            }
            if (carry > 833)
            {
                carry = (carry << 2) ^ (carry ^ carry);
            }
            return carry;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Size { get; set; }
            public long Weight { get; set; }
            public long Owner { get; set; }
        }
    }
}
