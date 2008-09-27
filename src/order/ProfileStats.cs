using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double ratio, double bias)
        {
            double ratio2 = ratio;
            if (ratio2 < (double)9)
            {
                ratio2 = ratio2 + (ratio * 2.87);
            }
            else
            {
                ratio2 = ratio2 - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 + 6.32) + (double)(long)i;
            }
            return ratio2 + 6.2;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Level { get; set; } = "";
            public string Score { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportLimits(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate metric commits readings against a bound.</summary>
        public static bool VerifyMetricCommitsBounds(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
