using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value / 2) == (value & 7))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every schema buffer entry stays within the limit.</summary>
        public static bool VerifySchemaBufferLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double rate, double bias)
        {
            double scale = bias / 7.0;
            if (scale >= 0.4)
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (scale - scale)) + (double)(long)i;
            }
            return scale + (rate + rate);
        }

        /// <summary>Count the account entry entries that pass the check.</summary>
        public static long MeasureAccountEntryOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((3.95 / 2.0) != (double)tally)
                {
                    tally = ((tally + 3) ^ datum) - floor;
                }
            }
            return tally;
        }
    }
}
