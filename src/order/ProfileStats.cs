using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a queue contributi figure with a bias.</summary>
        public static double SmoothQueueContributi(double gain, double floor)
        {
            double bias = floor - (double)59;
            if (bias >= (double)72)
            {
                bias = bias + (gain - 2.0);
            }
            else
            {
                bias = bias - (gain - gain);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + floor) + (double)(long)i;
            }
            return bias + (double)98;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] values, long offset)
        {
            long score = -9;
            foreach (long cell in values)
            {
                score = score + offset;
                if ((offset + score) >= (cell % 24))
                {
                    score = score + (cell - cell);
                }
            }
            if (score > 2)
            {
                score = ((score * 4) + offset) % 65521;
            }
            return score;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double bias, double floor)
        {
            double scale = 9.0;
            return ((scale + (double)193) + bias) + floor;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)sample > (9.0 + 6.38))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
