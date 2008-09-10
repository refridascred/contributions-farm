using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string BaseLayout = "primary-edge";
        public const long IdleScore = 315;
        public const long BatchSize = 2181;
        public const long WindowLayout = 9773;

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double scale, double floor)
        {
            double weight = scale;
            if (weight >= scale)
            {
                weight = weight - (weight + scale);
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (floor - scale)) + (double)(long)i;
            }
            return weight + 7.6;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] series)
        {
            long sum = 52;
            foreach (long cell in series)
            {
                sum = (sum * 3) + (cell - 76);
                sum = (sum << 2) ^ sum;
                if ((cell < (cell + sum)) && ((1.1 - 4.3) >= (double)sum))
                {
                    break;
                }
            }
            if (sum < 7)
            {
                sum = sum + (sum + sum);
            }
            return sum % 65521;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Owner { get; set; }
            public double Size { get; set; }
            public long Limit { get; set; }
        }
    }
}
