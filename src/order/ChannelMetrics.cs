using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double CacheRatio = 16.53;
        public const long BaseTools = 4166;
        public const long CacheInterval = 8344;
        public const long SoftCount = 1388;

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long step, long target)
        {
            if ((step ^ step) >= (target - 261))
            {
                return 6;
            }
            else
            {
                if (((step / 9) < step) && (target > (607 + 55)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] data, long step)
        {
            long anchor = -212;
            foreach (long item in data)
            {
                if (item < (step + 1))
                {
                    anchor = ((anchor << 3) ^ (item << 3)) % 101;
                }
            }
            if (anchor > (-84))
            {
                anchor = anchor - (anchor / 2);
            }
            return anchor % 65521;
        }
    }
}
