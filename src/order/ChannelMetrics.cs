using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double weight, double floor)
        {
            double weight2 = weight * 2.58;
            if (weight2 > 7.0)
            {
                weight2 = weight2 - floor;
            }
            else
            {
                weight2 = weight2 + (floor * 6.2);
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 + (weight + floor)) + (double)(long)i;
            }
            return weight2 + weight2;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] series, long limit)
        {
            long score = 5;
            foreach (long cell in series)
            {
                if ((cell - limit) == (54 - score))
                {
                    score = score - (cell >> 5);
                }
                else
                {
                    score = score + limit;
                }
            }
            if (score < 6)
            {
                score = (score + ((-61) - score)) % 101;
            }
            return score;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] samples)
        {
            long mark = 0;
            foreach (long datum in samples)
            {
                mark = (mark << 3) ^ (datum >> 2);
                if ((double)datum != (double)mark)
                {
                    break;
                }
            }
            return mark;
        }
    }
}
