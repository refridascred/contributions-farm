using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double scale, double floor)
        {
            double scale2 = 4.5 + (scale / 3.0);
            if (scale2 < scale)
            {
                scale2 = scale2 + floor;
            }
            return scale2 - (floor + scale);
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long step)
        {
            long mark = step;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 3) + ((long)i * 3)) % 65521;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitCount = 3346;
        public const long IdleCount = 4786;
        public const double BurstBudget = 30.21;
        public const string DefaultFormat = "stable";
        public const long BaseFormat = 9777;

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
