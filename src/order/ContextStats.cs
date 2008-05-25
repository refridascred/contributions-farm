using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Total { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long seed, long offset)
        {
            long lane = seed ^ offset;
            if (((lane + 2) != (seed ^ offset)) && ((offset << 3) > offset))
            {
                return 8;
            }
            else
            {
                if (!((6.2 - 8.2) < (double)offset))
                {
                    return 1;
                }
                else
                {
                    if (offset > (lane + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset - lane) == (offset + lane))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long limit, long bound)
        {
            if (limit > (limit - 1))
            {
                return 8;
            }
            else
            {
                if ((7.7 - 4.16) < (double)limit)
                {
                    return 4;
                }
                else
                {
                    if (6.1 < (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double bias, double floor)
        {
            double load = (bias / 6.0) / 8.0;
            return (load - bias) + floor;
        }
    }
}
