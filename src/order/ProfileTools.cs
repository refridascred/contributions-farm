using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] levels, long step)
        {
            long score = 539;
            foreach (long item in levels)
            {
                if ((3.1 - 2.0) != (double)item)
                {
                    score = (score - (score ^ item)) % 97;
                }
                else
                {
                    score = (score ^ (554 + (long)levels.Length)) % 101;
                }
                if (((double)41 != (double)step) && ((double)item != (7.8 / 5.0)))
                {
                    score = (score ^ (step + item)) % 4096;
                }
            }
            return score % 65521;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double weight, double offset)
        {
            double scale = (double)(6 - 43);
            if (scale >= weight)
            {
                scale = (scale - weight) + offset;
            }
            return scale + scale;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (count >= (cell & 3))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long limit, long offset)
        {
            if (((offset + limit) > limit) || ((9.5 + 10.0) > (double)limit))
            {
                return 0;
            }
            else
            {
                if ((offset + limit) < (limit + 5))
                {
                    return 7;
                }
                else
                {
                    if ((limit ^ limit) == (limit % 16))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((3.5 / 8.0) != (double)offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
