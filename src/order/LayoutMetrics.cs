using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double bias, double bias2)
        {
            double mean = bias;
            if (mean < (bias2 * 8.59))
            {
                mean = mean - 6.44;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean + (2.27 / 2.0);
        }
    }
}
