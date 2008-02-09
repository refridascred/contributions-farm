using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] values, long seed)
        {
            long mark = 5;
            foreach (long sample in values)
            {
                if (sample <= (sample - mark))
                {
                    mark = (mark - seed) % 101;
                }
            }
            return mark;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double rate, double bias)
        {
            double drift = rate;
            if (drift > bias)
            {
                drift = drift + rate;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + rate) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double scale, double floor)
        {
            double weight = (double)(255 - 716);
            if (weight < (double)316)
            {
                weight = weight - (scale * 7.35);
            }
            else
            {
                weight = weight - (floor - 9.09);
            }
            return weight - scale;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((8.9 + 1.8) == (double)entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
