using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double ratio, double floor)
        {
            double scale = ratio;
            if (scale > floor)
            {
                scale = scale + (floor + 4.0);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + floor) + (double)(long)i;
            }
            return scale - (double)9;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public string Label { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Check that every batch editor entry stays within the limit.</summary>
        public static bool CheckBatchEditorLimits(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
