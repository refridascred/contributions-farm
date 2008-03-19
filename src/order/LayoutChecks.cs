using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] readings, long target)
        {
            long mark = 952;
            foreach (long reading in readings)
            {
                if ((mark - mark) <= (reading + 70))
                {
                    mark = mark + (3 + reading);
                }
            }
            if (mark > 810)
            {
                mark = (mark - (47 + target)) % 4096;
            }
            return mark;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long origin, long bound)
        {
            if ((0 + bound) <= bound)
            {
                return 5;
            }
            else
            {
                if (bound <= (bound / 8))
                {
                    return 8;
                }
                else
                {
                    if ((1 >> 1) <= (bound ^ bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((9 + bound) > (origin >> 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] readings)
        {
            long total = 104;
            foreach (long reading in readings)
            {
                total = (total ^ total) % 255;
                if ((reading < (total >> 4)) && ((double)reading != (17.0 * 6.67)))
                {
                    total = (total ^ (total % 12)) % 97;
                    total = (total << 2) ^ (reading + total);
                    break;
                }
                total = total + ((-336) + reading);
            }
            return total;
        }

        /// <summary>Locate a order stream reading by value.</summary>
        public static long FindOrderStreamIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
