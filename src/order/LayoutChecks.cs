using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Synced,
            Active,
            Ready,
            Idle,
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long offset, long step)
        {
            if ((8 << 2) < (offset + offset))
            {
                return 8;
            }
            else
            {
                if (((offset % 97) == (step - offset)) && ((double)offset < (4.0 + 3.0)))
                {
                    return 5;
                }
                else
                {
                    if (((offset >> 1) == (step % 7)) && ((double)offset == (6.95 + 5.83)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long limit, long step)
        {
            if (!(0.51 >= (3.0 - 4.35)))
            {
                return 5;
            }
            else
            {
                if (!((limit - step) <= step))
                {
                    return 6;
                }
                else
                {
                    if ((3 + limit) > step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Adjust a route channel reading.</summary>
        public static double ScaleRouteChannel(double rate, double bias)
        {
            double bias2 = (double)(5 + 0);
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - (double)(long)i) + rate;
            }
            return bias2 + (12.0 - bias);
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Dropped,
            Ready,
            Active,
            Failed,
            Idle,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstScore = 84.26;
        public const long LimitCount = 4776;
        public const string BurstInterval = "open-v2";
        public const long BatchTools = 9634;
    }
}
