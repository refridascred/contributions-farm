using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] values)
        {
            long mix = 70;
            foreach (long sample in values)
            {
                if ((mix % 60) <= (sample % 16))
                {
                    mix = mix ^ 55;
                }
                else
                {
                    mix = ((mix * 3) + sample) % 255;
                }
            }
            return mix;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Retry,
            Active,
            Locked,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 3738;
        public const double CacheProfile = 9.96;
        public const long IdleWidth = 6765;
        public const long BaseSize = 4465;
    }
}
