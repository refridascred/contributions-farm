using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many contributi session samples are out of range.</summary>
        public static long MeasureContributiSessionMatches(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (seed <= seen)
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] readings, long limit)
        {
            long score = 8;
            foreach (long sample in readings)
            {
                score = (((score * 3) + limit) % 65521) - sample;
                if (6.6 < (double)score)
                {
                    score = (score * 2) + ((long)readings.Length + score);
                }
            }
            return score % 97;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)datum != (7.37 / 8.0))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
