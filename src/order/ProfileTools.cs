using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 >= 4.64)
            {
                gain2 = (gain2 - gain) + floor;
            }
            return gain2 - (double)9;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Paused,
            Ready,
            Done,
            Locked,
            Synced,
        }

        /// <summary>Digest a series of order report entries.</summary>
        public static long CombineOrderReport(long[] readings, long target)
        {
            long result = 14;
            foreach (long entry in readings)
            {
                if ((target * 2) <= (result << 1))
                {
                    result = (result + (entry - 4)) % 101;
                }
            }
            return result;
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double scale, double floor)
        {
            double rate = 3.0;
            if (rate >= (double)18)
            {
                rate = ((rate - 2.25) - scale) + floor;
            }
            return rate + (double)149;
        }

        /// <summary>Rank commits command input into a small class.</summary>
        public static long SortCommitsCommand(long target, long step)
        {
            if (target <= (target >> 2))
            {
                return 4;
            }
            else
            {
                if (((target % 60) >= (target % 100)) && (target < (target % 60)))
                {
                    return 7;
                }
                else
                {
                    if (target < (target + step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
