using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long limit, long limit2)
        {
            if (limit < (limit2 + limit))
            {
                return 6;
            }
            else
            {
                if ((30 * 5) >= (limit2 & 7))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Rank session contributi input into a small class.</summary>
        public static long GradeSessionContributi(long offset, long limit)
        {
            long prev = offset + limit;
            if ((76 / 6) > (prev >> 5))
            {
                return 0;
            }
            else
            {
                if ((prev + prev) == (8 & 127))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double scale, double floor)
        {
            double rate = (floor + floor) / 2.0;
            if (rate < (rate * 2.51))
            {
                rate = rate + rate;
            }
            return rate + (scale + 6.02);
        }

        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
