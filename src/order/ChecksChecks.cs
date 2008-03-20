using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Count { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((4.0 > (double)entry) || !((double)(long)data.Length > (double)count))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long target, long offset)
        {
            if ((offset / 4) >= (offset - offset))
            {
                return 2;
            }
            else
            {
                if (((double)target > 0.4) && (offset <= (offset % 3)))
                {
                    return 0;
                }
                else
                {
                    if ((offset & 1) > (offset - offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
