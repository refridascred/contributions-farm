using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 9920;
        public const long LimitDepth = 5428;
        public const double WindowSpan = 62.22;
        public const long WindowBuffer = 8283;

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long offset, long floor)
        {
            if ((offset ^ offset) >= (offset + offset))
            {
                return 1;
            }
            else
            {
                if ((1.78 * 15.0) >= (double)floor)
                {
                    return 2;
                }
                else
                {
                    if ((4.22 * 6.1) > (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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
