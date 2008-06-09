using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every profile report entry stays within the limit.</summary>
        public static bool VerifyProfileReportBounds(long[] readings, long step)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up session commits samples.</summary>
        public static long CompareSessionCommitsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two profile support measurements.</summary>
        public static double BlendProfileSupport(double bias, double bias2)
        {
            double drift = 8.9;
            return ((drift + (double)27) + bias) + bias2;
        }
    }
}
