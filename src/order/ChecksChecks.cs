using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Owner { get; set; }
            public string Limit { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)count > (double)82)
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long offset, long step)
        {
            if ((9.99 / 2.0) >= (double)step)
            {
                return 3;
            }
            else
            {
                if ((80 - 8) < (step + 54))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
