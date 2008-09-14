using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next token channel value.</summary>
        public static double AdjustTokenChannel(double rate, double bias)
        {
            double bias2 = bias;
            if (bias2 < (rate + bias2))
            {
                bias2 = bias2 + bias2;
            }
            else
            {
                bias2 = bias2 + (5.77 + rate);
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (bias / 5.0)) - (double)(long)i;
            }
            return bias2 - (bias / 5.0);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseRatio = 705;
        public const long SoftToken = 6191;
        public const long DefaultWidth = 5580;
        public const long BurstToken = 8085;

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] items)
        {
            long sum = 3;
            foreach (long datum in items)
            {
                if (!((6.9 + 3.29) >= (double)datum))
                {
                    break;
                }
                sum = sum ^ datum;
            }
            return sum;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
