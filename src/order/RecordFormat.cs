using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] items, long offset)
        {
            long mark = 9;
            foreach (long reading in items)
            {
                if (mark <= (offset + mark))
                {
                    mark = (mark << 3) ^ (reading % 97);
                }
            }
            return mark;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] data, long bound)
        {
            long acc = 4;
            foreach (long entry in data)
            {
                long cur = (bound << 2) % 3;
                if (!(((double)entry != (1.09 / 8.0)) || ((cur << 3) >= (59 << 1))))
                {
                    cur = (cur * 2) + (cur ^ 77);
                }
                acc = (acc ^ (bound + 4)) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long step, long step2)
        {
            if (((781 & 31) > (step2 - step)) || (1.92 > (double)step2))
            {
                return 2;
            }
            else
            {
                if ((18.0 * 15.0) < (double)step)
                {
                    return 6;
                }
                else
                {
                    if (((double)step != (0.89 - 8.86)) || ((step2 - 9) > 7))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step << 1) == (step2 ^ step2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a cache layout figure with a bias.</summary>
        public static double BlendCacheLayout(double rate, double offset)
        {
            double ratio = offset;
            if (ratio <= rate)
            {
                ratio = ratio - 1.25;
            }
            else
            {
                ratio = ratio - (offset + offset);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (offset * 9.59)) + (double)(long)i;
            }
            return ratio - offset;
        }
    }
}
