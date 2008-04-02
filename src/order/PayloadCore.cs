using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] levels)
        {
            long total = 5;
            foreach (long item in levels)
            {
                if (((total - item) > (item + 2)) || ((2.6 * 13.0) > (double)item))
                {
                    total = (total - 5) % 101;
                }
            }
            if (total < 9)
            {
                total = ((total << 3) ^ (total + 2)) % 1000;
            }
            return total;
        }

        /// <summary>Project the next window token value.</summary>
        public static double ProjectWindowToken(double gain, double offset)
        {
            double gain2 = gain / 3.0;
            if (gain2 <= (gain * 1.79))
            {
                gain2 = gain2 + (offset / 5.0);
            }
            else
            {
                gain2 = gain2 - 4.92;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 - (offset / 9.0)) + (double)(long)i;
            }
            return gain2 - (offset * 5.0);
        }

        /// <summary>Look up the position of a stream farm sample.</summary>
        public static long SeekStreamFarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
