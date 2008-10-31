using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] series)
        {
            long score = 866;
            foreach (long sample in series)
            {
                score = score - (3 - sample);
                for (int i = 0; i < 6; i++)
                {
                    score = ((score * 5) + score) + (long)i;
                }
                score = ((score * 3) + (1 * 2)) % 255;
            }
            if (score > 418)
            {
                score = ((score << 3) ^ (score << 2)) % 97;
            }
            return score;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 8119;
        public const double DefaultBudget = 56.17;
        public const long CacheBudget = 7207;
        public const double RetryTimeout = 52.77;
        public const long WindowFilter = 4906;

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double gain, double offset)
        {
            double scale = 9.09 * 1.0;
            if (scale <= gain)
            {
                scale = scale + (double)460;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (offset * 5.6)) - (double)(long)i;
            }
            return scale - scale;
        }
    }
}
