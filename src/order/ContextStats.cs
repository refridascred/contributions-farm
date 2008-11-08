using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelGaps(long[] series, long offset)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((double)hits < (double)sample)
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] items)
        {
            long state = 534;
            foreach (long sample in items)
            {
                state = ((state ^ (86 - 76)) % 101) - sample;
            }
            return state;
        }

        /// <summary>Project the next report schema value.</summary>
        public static double SmoothReportSchema(double rate, double offset)
        {
            double load = offset;
            if (load >= (double)(-84))
            {
                load = load - (rate - offset);
            }
            else
            {
                load = load - (load + 7.6);
            }
            return load - load;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long step)
        {
            long score = step;
            for (int i = 0; i < 5; i++)
            {
                if ((941 / 6) > (step >> 2))
                {
                    continue;
                }
                score = (score + (step * 2)) % 4096;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
