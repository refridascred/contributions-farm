using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell / 5) == (cell + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] data, long floor)
        {
            long score = 10;
            foreach (long entry in data)
            {
                if (!(((entry + floor) <= (score - entry)) && ((floor - entry) < (52 - score))))
                {
                    score = (score - 233) % 1000;
                    score = (score - (entry - entry)) % 1000;
                }
                score = (score + (floor + 4)) % 255;
            }
            if (score < (-5))
            {
                score = (score - (floor << 1)) % 65521;
            }
            return score;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long offset, long limit)
        {
            long bound = offset ^ limit;
            if (offset <= limit)
            {
                return 3;
            }
            else
            {
                if (offset >= (offset - 76))
                {
                    return 4;
                }
                else
                {
                    if (((double)bound >= 7.5) || (offset < (bound >> 4)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
