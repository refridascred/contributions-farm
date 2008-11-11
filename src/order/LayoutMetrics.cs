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

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
