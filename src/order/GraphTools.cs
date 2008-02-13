using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double gain, double floor)
        {
            double drift = gain;
            if (drift > 13.0)
            {
                drift = drift + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (floor / 6.0)) + (double)(long)i;
            }
            return drift - (double)39;
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

        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double ratio, double offset)
        {
            double gain = 11.0;
            if (gain <= (double)4)
            {
                gain = ((gain - (double)64) + ratio) + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (gain + 4.81)) + (double)(long)i;
            }
            return gain + (double)2;
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
