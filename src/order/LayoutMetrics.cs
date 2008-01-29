using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 1004;
        public const long StepProfile = 4750;
        public const string CacheProfile = "strict";
        public const long DefaultProfile = 1992;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Stale,
            Pending,
            Synced,
            Failed,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] readings, long floor)
        {
            long anchor = 89;
            foreach (long item in readings)
            {
                anchor = (anchor - (954 >> 5)) % 101;
                if ((9.88 + 6.0) == (double)anchor)
                {
                    anchor = (anchor ^ (floor >> 2)) % 101;
                }
                else
                {
                    anchor = anchor ^ (floor << 2);
                }
                if (((double)anchor < (4.87 - 7.16)) && (anchor >= (item / 9)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
