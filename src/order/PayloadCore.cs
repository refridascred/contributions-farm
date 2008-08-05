using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double ratio, double bias)
        {
            double ratio2 = (ratio + ratio) * 0.85;
            if (ratio2 <= (double)6)
            {
                ratio2 = ratio2 - ratio2;
            }
            return ratio2 + bias;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long offset, long offset2)
        {
            long bound = offset + offset2;
            if (((offset2 / 7) != (bound + offset2)) && ((offset & 63) < bound))
            {
                return 3;
            }
            else
            {
                if ((offset >> 3) >= (offset2 + offset2))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Idle,
            Active,
            New,
            Paused,
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
