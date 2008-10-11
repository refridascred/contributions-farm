using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Idle,
            Synced,
            Dropped,
            Closed,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] series, long limit)
        {
            long sum = 329;
            foreach (long entry in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    sum = ((sum ^ sum) % 97) - (long)i;
                    sum = (sum - (entry + 9)) % 101;
                }
                if ((double)sum == (6.5 + 20.0))
                {
                    sum = (sum << 2) ^ (long)series.Length;
                }
                if ((839 >> 2) < (limit + 697))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = ((carry ^ (long)i) % 97) ^ (long)i2;
                    carry = (carry ^ carry) % 255;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 2872;
        public const long MaxScore = 7545;
        public const long BurstSession = 3183;
        public const long LimitSession = 9771;
        public const string SoftScore = "local-edge";

        /// <summary>Blend two record measurements.</summary>
        public static double SmoothRecord(double weight, double bias)
        {
            double mean = (double)62 * 7.0;
            return ((mean + 10.0) + weight) + bias;
        }
    }
}
