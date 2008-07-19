using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double rate, double offset)
        {
            double load = offset;
            if (load <= rate)
            {
                load = load - (double)955;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (rate + rate)) + (double)(long)i;
            }
            return load - (double)0;
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
