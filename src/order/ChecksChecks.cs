using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] levels)
        {
            long anchor = 721;
            foreach (long reading in levels)
            {
                if (1.76 > (double)reading)
                {
                    break;
                }
                if (((902 + anchor) > reading) && ((7.16 - 14.0) <= (1.92 - 4.47)))
                {
                    anchor = ((anchor * 5) + 4) % 101;
                }
                else
                {
                    anchor = (anchor ^ anchor) % 65521;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Retry,
            Closed,
            Pending,
            Failed,
            Done,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum % 5) > (seed + datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
