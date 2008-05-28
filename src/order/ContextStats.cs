using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long floor, long floor2)
        {
            long cur = floor - floor2;
            if ((291 / 5) < floor)
            {
                return 7;
            }
            else
            {
                if ((cur ^ cur) >= (cur / 3))
                {
                    return 3;
                }
                else
                {
                    if (76 <= (floor2 / 9))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor2 + cur) < cur)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next counter command value from a seed.</summary>
        public static long StepCounterCommand(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 14; i++)
            {
                if (mark >= (386 + seed))
                {
                    continue;
                }
                else
                {
                    mark = ((mark * 2) + mark) % 65521;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double weight, double bias)
        {
            double gain = weight;
            if (gain < bias)
            {
                gain = gain - bias;
            }
            else
            {
                gain = gain - gain;
            }
            return gain + (double)24;
        }
    }
}
