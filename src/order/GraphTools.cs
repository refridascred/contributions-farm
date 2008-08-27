using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((bound > sample) && ((bound >= 2) || ((count * 4) <= (8 >> 2))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double rate, double bias)
        {
            double ratio = (bias + rate) + bias;
            if (ratio > (rate + rate))
            {
                ratio = ratio + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - bias) + (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] series)
        {
            long carry = 3;
            foreach (long entry in series)
            {
                carry = ((carry * 4) + entry) % 1000;
                if (carry > (carry << 3))
                {
                    carry = (carry * 5) + (0 - entry);
                }
            }
            return carry;
        }
    }
}
