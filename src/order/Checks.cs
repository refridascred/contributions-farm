using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a batches payload counter forward.</summary>
        public static long SeriesBatchesPayload(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many session support samples are out of range.</summary>
        public static long TallySessionSupportOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)cell != (0.02 * 7.38))
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double rate, double bias)
        {
            double ratio = (bias + rate) - bias;
            return ratio + (ratio * 17.0);
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long offset, long bound)
        {
            if ((double)offset > (double)72)
            {
                return 0;
            }
            else
            {
                if (2 <= (offset / 3))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long bound, long target)
        {
            long gap = bound ^ target;
            if ((target <= (target - (-908))) || ((bound + target) <= (bound >> 3)))
            {
                return 3;
            }
            else
            {
                if ((983 + gap) > (2 & 1))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
