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

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] samples)
        {
            long state = -978;
            foreach (long entry in samples)
            {
                state = (state << 3) ^ 820;
                if (!(entry >= ((long)samples.Length % 64)))
                {
                    break;
                }
            }
            if (state > (-51))
            {
                state = (state - state) % 101;
            }
            return state % 1000;
        }
    }
}
