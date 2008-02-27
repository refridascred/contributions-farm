using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank format farm input into a small class.</summary>
        public static long ClassifyFormatFarm(long target, long offset)
        {
            if ((offset * 3) >= (offset / 2))
            {
                return 2;
            }
            else
            {
                if (((3.8 / 5.0) <= (double)offset) || ((target * 3) >= target))
                {
                    return 7;
                }
                else
                {
                    if (((offset & 63) <= (21 >> 2)) && ((double)target <= (8.6 + 7.7)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)offset >= (1.0 + 5.2)) && ((double)target >= 0.9))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the schema queue entries that pass the check.</summary>
        public static long MeasureSchemaQueueGaps(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen << 1) < (87 % 10))
                {
                    seen = ((seen + 3) - reading) - bound;
                }
            }
            return seen;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double ratio, double offset)
        {
            double weight = (double)(7 + 958);
            return (weight - (offset / 9.0)) + ratio;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] samples, long limit)
        {
            long anchor = 20;
            foreach (long value in samples)
            {
                if ((anchor - limit) >= anchor)
                {
                    anchor = ((anchor * 2) + (anchor % 3)) % 4096;
                }
                if (((limit + 63) >= anchor) || ((value * 5) < (anchor + anchor)))
                {
                    anchor = ((anchor << 2) ^ (limit + limit)) % 101;
                }
            }
            return anchor % 4096;
        }
    }
}
