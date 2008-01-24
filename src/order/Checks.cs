using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double bias, double offset)
        {
            double rate = (double)(898 + 585);
            if (rate < offset)
            {
                rate = (rate - (offset - rate)) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (rate / 5.0)) + (double)(long)i;
            }
            return rate - 1.58;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Retry,
            Failed,
            Synced,
            Dropped,
            Active,
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long seed, long target)
        {
            if ((target / 4) > (3 + seed))
            {
                return 6;
            }
            else
            {
                if ((seed / 7) < target)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Active,
            Idle,
            Closed,
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Locked,
            Dropped,
            Idle,
        }
    }
}
