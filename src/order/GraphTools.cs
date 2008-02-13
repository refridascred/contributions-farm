using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two commits contributi measurements.</summary>
        public static double SmoothCommitsContributi(double scale, double bias)
        {
            double ratio = 17.0;
            if (ratio > (scale / 4.0))
            {
                ratio = ratio - (bias * 8.39);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (scale + bias)) + (double)(long)i;
            }
            return ratio + (ratio * 2.3);
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Mode { get; set; }
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long origin, long offset)
        {
            if ((42 >> 4) > (origin + origin))
            {
                return 6;
            }
            else
            {
                if ((offset >> 4) < (origin & 7))
                {
                    return 2;
                }
                else
                {
                    if (!((origin - 4) <= 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((2.32 - 7.0) <= (double)offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ScaleBatch(double bias, double span)
        {
            double bias2 = span * 13.0;
            return (bias2 - (13.0 * 7.0)) + bias;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Locked,
            Closed,
            Done,
            New,
        }
    }
}
