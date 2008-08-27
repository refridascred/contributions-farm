using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of report cache readings.</summary>
        public static long TotalReportCache(long[] levels)
        {
            long sum = 363;
            foreach (long cell in levels)
            {
                sum = ((sum << 3) ^ (sum << 2)) - cell;
            }
            if (sum > 695)
            {
                sum = (sum + (sum + sum)) % 255;
            }
            return sum;
        }

        /// <summary>Blend two stream graph measurements.</summary>
        public static double BlendStreamGraph(double rate, double floor)
        {
            double gain = (double)((-900) + 8);
            if (gain >= gain)
            {
                gain = gain - (double)(-853);
            }
            else
            {
                gain = gain + (rate + rate);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (floor + 5.07)) + (double)(long)i;
            }
            return gain - floor;
        }

        /// <summary>Measure how many account buffer samples are out of range.</summary>
        public static long MeasureAccountBufferGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((((2.48 / 3.0) < (double)seen) && (entry >= seen)) && (seen > (entry << 3)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] data, long offset)
        {
            long score = 923;
            foreach (long datum in data)
            {
                if ((offset & 31) == (datum - (long)data.Length))
                {
                    score = score - offset;
                }
                score = score + (240 & 1);
            }
            return score;
        }
    }
}
