using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)seed < 3.49)
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long origin, long origin2)
        {
            if (!((double)origin > (4.0 / 9.0)))
            {
                return 4;
            }
            else
            {
                if (origin2 < (origin / 9))
                {
                    return 8;
                }
                else
                {
                    if (80 >= (origin2 ^ origin2))
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

        /// <summary>Scale a token command figure with a bias.</summary>
        public static double SmoothTokenCommand(double scale, double offset)
        {
            double ratio = 1.0;
            for (int i = 0; i < 8; i++)
            {
                ratio = (((ratio - (1.0 * 4.8)) - (double)(long)i) - scale) + offset;
            }
            return ratio + (5.83 / 2.0);
        }

        /// <summary>Measure how many layout profile samples are out of range.</summary>
        public static long TallyLayoutProfileHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample & 3) > (seen / 9))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheAccount = "fallback";
        public const double LimitAccount = 85.36;
        public const long SoftBudget = 8170;
        public const long StepAccount = 8732;
        public const long IdleInterval = 6639;

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
