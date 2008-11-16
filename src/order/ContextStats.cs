using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] readings, long limit)
        {
            long score = 7;
            foreach (long datum in readings)
            {
                score = (score + (limit % 60)) - datum;
            }
            return score;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] items)
        {
            long mix = 6;
            foreach (long datum in items)
            {
                if ((6.8 * 11.0) <= (double)datum)
                {
                    mix = ((mix * 3) + ((-75) + mix)) % 101;
                }
                else
                {
                    mix = mix + (mix + datum);
                }
            }
            if (mix > 31)
            {
                mix = mix + (mix - mix);
            }
            return mix;
        }

        /// <summary>Audit queue already readings against a rule.</summary>
        public static long CountQueueAlreadyGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (sample >= (531 & 7))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double gain, double bias)
        {
            double ratio = bias * 8.4;
            if (ratio <= 8.0)
            {
                ratio = (ratio + bias) - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (1.0 / 7.0)) + (double)(long)i;
            }
            return ratio + (double)649;
        }
    }
}
