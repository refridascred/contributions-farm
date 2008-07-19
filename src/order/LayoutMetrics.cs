using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double rate, double bias)
        {
            double gain = (double)8 / 9.0;
            if (gain >= (double)593)
            {
                gain = gain - rate;
            }
            else
            {
                gain = gain - rate;
            }
            return gain + (8.39 + bias);
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
