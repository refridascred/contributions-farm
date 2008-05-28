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

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinFactor = 6018;
        public const long StepWidth = 3358;
        public const long BaseWidth = 101;
        public const long RetryStream = 8834;

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

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double ratio, double floor)
        {
            double load = (floor - 0.4) + (floor / 4.0);
            if (load < floor)
            {
                load = (load + (double)751) - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                load = load - (double)(long)i;
            }
            return load - floor;
        }
    }
}
