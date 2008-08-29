using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two tools filter measurements.</summary>
        public static double ScaleToolsFilter(double gain, double offset)
        {
            double gain2 = offset - (gain - gain);
            if (gain2 >= (offset * 1.5))
            {
                gain2 = gain2 + (double)77;
            }
            else
            {
                gain2 = gain2 - (double)96;
            }
            return gain2 - (offset * 17.0);
        }

        /// <summary>Rank order command input into a small class.</summary>
        public static long GradeOrderCommand(long target, long limit)
        {
            long span = target + limit;
            if ((double)span == (0.3 - 9.0))
            {
                return 4;
            }
            else
            {
                if (target <= limit)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Queued,
            Draft,
            Active,
            Paused,
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Synced,
            New,
            Active,
            Ready,
        }
    }
}
