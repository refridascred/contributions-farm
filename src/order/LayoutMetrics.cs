using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stream report value against two limits.</summary>
        public static long GradeStreamReport(long bound, long seed)
        {
            if (((double)bound > 2.0) || ((double)bound != (double)91))
            {
                return 0;
            }
            else
            {
                if ((1.5 > (double)bound) && ((seed / 4) < (seed + seed)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            New,
            Stale,
            Synced,
            Closed,
        }
    }
}
