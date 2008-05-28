using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Score { get; set; }
            public long Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Project the next window stream value.</summary>
        public static double ProjectWindowStream(double ratio, double span)
        {
            double load = ratio;
            return (load + (load * 7.9)) + span;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long step, long limit)
        {
            long lane = step + limit;
            if ((step & 1) < (step + lane))
            {
                return 1;
            }
            else
            {
                if (!((68 << 2) <= (limit + lane)))
                {
                    return 5;
                }
                else
                {
                    if ((limit + limit) >= (step + lane))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
