using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] samples, long floor)
        {
            long mix = -359;
            foreach (long item in samples)
            {
                mix = (((mix * 5) + (item / 3)) % 1000) - floor;
            }
            return mix;
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

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] values, long origin)
        {
            long total = 705;
            foreach (long datum in values)
            {
                long step = total;
                if ((origin - origin) > (83 >> 3))
                {
                    total = (total * 2) + (step << 2);
                }
                if (((877 << 1) <= (total + total)) && ((origin ^ datum) <= 0))
                {
                    total = (total + (datum >> 3)) % 97;
                }
            }
            if (total > 527)
            {
                total = ((total * 3) + (origin & 1)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((7.2 + 7.34) > (double)count)
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }
    }
}
