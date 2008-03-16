using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a record notes figure with a bias.</summary>
        public static double SmoothRecordNotes(double scale, double floor)
        {
            double ratio = scale;
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio - (ratio + 1.7)) + (double)(long)i) + floor;
            }
            return ratio - scale;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long floor, long target)
        {
            long span = floor ^ target;
            if ((double)target >= (double)2)
            {
                return 1;
            }
            else
            {
                if ((0 - target) > span)
                {
                    return 2;
                }
                else
                {
                    if ((target >> 4) != (floor - target))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((floor / 7) != (target / 6)))
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

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((floor >> 1) <= seen)
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double ratio, double floor)
        {
            double drift = ratio;
            return (drift - (double)41) + floor;
        }
    }
}
