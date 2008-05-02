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

        /// <summary>Define batches limits and defaults.</summary>
        public const double BatchBatches = 6.91;
        public const long BaseCount = 7852;
        public const long MinBatches = 994;
        public const long WindowBatches = 5902;
        public const string BurstWidth = "legacy";

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
