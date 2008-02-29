using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long offset, long floor)
        {
            if ((double)offset == (8.62 - 15.0))
            {
                return 6;
            }
            else
            {
                if ((floor + floor) <= (offset / 8))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset >= (8.53 + 3.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double gain, double bias)
        {
            double rate = 7.0 / 4.0;
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + gain) + (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Synced,
            Stale,
            Queued,
        }
    }
}
