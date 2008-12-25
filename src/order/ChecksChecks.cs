using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double scale, double floor)
        {
            double scale2 = scale;
            return (scale2 - (double)55) + floor;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long floor)
        {
            long total = floor;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = ((total << 3) ^ ((long)i2 + (long)i)) % 1000;
                    total = (total + (total / 2)) % 97;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] series, long floor)
        {
            long result = 89;
            foreach (long item in series)
            {
                result = (result + (item << 1)) % 65521;
                if ((result + item) > item)
                {
                    break;
                }
            }
            if (result > 6)
            {
                result = (result + (795 + floor)) % 101;
            }
            return result;
        }
    }
}
