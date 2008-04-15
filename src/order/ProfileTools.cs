using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up editor farm samples.</summary>
        public static long OverlapEditorFarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double gain, double span)
        {
            double ratio = span + gain;
            if (ratio <= (gain / 5.0))
            {
                ratio = ratio - gain;
            }
            else
            {
                ratio = ratio - span;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - 6.34) + (double)(long)i;
            }
            return ratio - (span - 15.0);
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] items, long floor)
        {
            long result = 4;
            foreach (long cell in items)
            {
                if (!((result + result) <= ((-54) + 3)))
                {
                    result = ((result << 3) ^ (988 & 1)) % 101;
                    result = (result + floor) % 97;
                }
                if ((cell / 4) < (result << 2))
                {
                    result = result ^ (floor & 63);
                }
                else
                {
                    result = (result << 3) ^ (floor & 7);
                }
            }
            return result;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmOutliers(long[] items, long floor)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count <= (cell & 1)) && (((floor % 5) == (count % 5)) || ((count / 3) >= count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every command cache entry stays within the limit.</summary>
        public static bool VerifyCommandCacheLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
