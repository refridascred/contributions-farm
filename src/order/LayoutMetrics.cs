using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Limit { get; set; } = "";
            public long Score { get; set; }
            public double Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double gain, double offset)
        {
            double mean = gain;
            if (mean <= (double)263)
            {
                mean = mean - (gain - offset);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (gain - offset)) + (double)(long)i;
            }
            return mean + (mean - gain);
        }

        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
