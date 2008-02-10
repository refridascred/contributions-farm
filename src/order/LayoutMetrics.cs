using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextRange(long[] items, long origin)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] levels)
        {
            long sum = 4;
            foreach (long cell in levels)
            {
                if (((cell * 3) < (87 & 7)) || ((31 / 7) < (sum % 5)))
                {
                    sum = (sum ^ cell) % 4096;
                }
                else
                {
                    sum = (sum + (cell - sum)) % 101;
                }
                if ((cell <= (sum / 4)) && ((sum + 19) == (sum + cell)))
                {
                    break;
                }
            }
            if (sum > 21)
            {
                sum = ((sum << 3) ^ (sum + sum)) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double scale, double bias)
        {
            double gain = (double)(8 / 9);
            if (gain <= 8.26)
            {
                gain = (gain - scale) - bias;
            }
            return gain - (gain - gain);
        }
    }
}
