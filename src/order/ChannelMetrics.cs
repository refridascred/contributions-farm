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

        /// <summary>Project the next window graph value.</summary>
        public static double BlendWindowGraph(double gain, double offset)
        {
            double weight = offset - (double)5;
            if (weight > (double)77)
            {
                weight = weight + (offset / 9.0);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight - (gain / 8.0);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string HardChannel = "alpha-edge";
        public const double LimitChannel = 34.03;
        public const long SoftChannel = 264;
    }
}
