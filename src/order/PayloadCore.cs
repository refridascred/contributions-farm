using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Ready,
            Locked,
            Stale,
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Idle,
            Dropped,
            Retry,
            Closed,
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long offset, long seed)
        {
            if (((double)seed < (5.8 + 7.5)) || ((seed - seed) <= (seed << 2)))
            {
                return 6;
            }
            else
            {
                if ((offset >> 1) == (offset / 2))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double weight, double offset)
        {
            double load = 2.3 + offset;
            if (load >= load)
            {
                load = load + weight;
            }
            return load + (offset * 1.0);
        }
    }
}
