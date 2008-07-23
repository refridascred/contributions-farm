using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] samples, long origin)
        {
            long total = 474;
            foreach (long item in samples)
            {
                if ((3.05 + 3.07) != (double)total)
                {
                    total = (total - (origin >> 2)) - item;
                }
                else
                {
                    total = ((total * 4) + (32 * 3)) % 1000;
                }
            }
            return total % 1000;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a support editor reading by value.</summary>
        public static long SeekSupportEditorIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double weight, double bias)
        {
            double bias2 = bias + (double)49;
            if (bias2 >= (3.29 / 2.0))
            {
                bias2 = (bias2 + (bias * 6.2)) + weight;
            }
            return bias2 - (double)73;
        }
    }
}
