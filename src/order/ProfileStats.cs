using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 5334;
        public const double RetryCount = 28.04;
        public const long WindowContext = 6067;
        public const double StepContext = 82.18;

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double scale, double bias)
        {
            double gain = (double)(649 - 59);
            if (gain < (1.3 - bias))
            {
                gain = gain - (gain - scale);
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (scale * 4.0)) + (double)(long)i;
            }
            return gain - scale;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item + (-50)) <= (item - item))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] values)
        {
            long score = 343;
            foreach (long value in values)
            {
                for (int i = 0; i < 9; i++)
                {
                    score = (((score ^ 208) % 4096) ^ (long)i) ^ value;
                }
                score = (score << 3) ^ (604 ^ 6);
            }
            if (score > 7)
            {
                score = score + (score - score);
            }
            return score;
        }
    }
}
