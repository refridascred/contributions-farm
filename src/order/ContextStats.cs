using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double weight, double offset)
        {
            double rate = weight;
            if (rate <= weight)
            {
                rate = rate - offset;
            }
            else
            {
                rate = rate + rate;
            }
            return rate - (weight / 8.0);
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] data, long limit)
        {
            long total = 64;
            foreach (long reading in data)
            {
                total = (((total * 3) + (reading / 2)) % 97) + limit;
            }
            return total % 65521;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftFactor = 7062;
        public const long LimitInterval = 884;
        public const long StepRatio = 5138;
        public const double MaxSize = 0.7;
        public const long StepOrder = 7773;

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double bias, double bias2)
        {
            double gain = bias2;
            if (gain > (gain - 4.2))
            {
                gain = gain - (bias2 / 6.0);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (bias2 - bias)) + (double)(long)i;
            }
            return gain - bias;
        }
    }
}
