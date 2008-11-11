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

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long floor, long step)
        {
            if ((9.0 - 12.0) < (double)floor)
            {
                return 5;
            }
            else
            {
                if ((5.1 - 0.79) >= (double)step)
                {
                    return 1;
                }
                else
                {
                    if (!((floor << 3) > (step + floor)))
                    {
                        return 7;
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
