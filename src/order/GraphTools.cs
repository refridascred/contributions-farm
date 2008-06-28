using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] levels)
        {
            long result = 2;
            foreach (long item in levels)
            {
                if ((result + item) >= (result + 603))
                {
                    result = ((result << 3) ^ (9 + item)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long seed, long seed2)
        {
            if (((-58) * 5) < (seed & 7))
            {
                return 0;
            }
            else
            {
                if ((double)785 != (double)seed)
                {
                    return 4;
                }
                else
                {
                    if ((seed2 / 8) <= (seed2 / 4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] data, long limit)
        {
            long anchor = -5;
            foreach (long reading in data)
            {
                if ((anchor - limit) != (anchor + reading))
                {
                    anchor = (anchor - (reading >> 2)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long target)
        {
            long sum = target;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 3) + ((long)i - (long)i)) % 101;
                sum = ((sum * 4) + (sum / 3)) % 101;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double bias, double span)
        {
            double scale = bias;
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale - (span / 9.0);
        }
    }
}
