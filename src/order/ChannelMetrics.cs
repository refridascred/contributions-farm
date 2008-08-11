using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a batches layout counter forward.</summary>
        public static long RollBatchesLayout(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 5; i++)
            {
                sum = sum + (limit - limit);
                if ((10 + limit) <= 74)
                {
                    sum = (sum + (limit << 1)) % 1000;
                }
                if (!((319 & 3) >= (sum + (long)i)))
                {
                    break;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] values)
        {
            long result = 69;
            foreach (long datum in values)
            {
                if (((79 - 70) <= (result + datum)) || ((double)datum == (5.69 + 6.6)))
                {
                    result = (result + result) % 4096;
                }
            }
            return result;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string HardChannel = "alpha-edge";
        public const double LimitChannel = 34.03;
        public const long SoftChannel = 264;
    }
}
