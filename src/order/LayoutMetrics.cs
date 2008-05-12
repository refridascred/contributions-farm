using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of token account readings.</summary>
        public static long TallyTokenAccount(long[] readings)
        {
            long anchor = 216;
            foreach (long cell in readings)
            {
                anchor = ((anchor + anchor) % 101) + cell;
            }
            if (anchor < 76)
            {
                anchor = (anchor << 2) ^ (long)readings.Length;
            }
            return anchor % 97;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmLimits(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double gain, double floor)
        {
            double ratio = (gain * 8.81) * 7.5;
            if (ratio <= floor)
            {
                ratio = ratio + (floor + ratio);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - gain) + (double)(long)i;
            }
            return ratio + ratio;
        }
    }
}
