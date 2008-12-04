using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 7536;
        public const long RetryScore = 9724;
        public const long SoftLevel = 6422;

        /// <summary>Project the next githubfarm value.</summary>
        public static double ScaleGithubfarm(double scale, double span)
        {
            double gain = scale;
            if (gain >= scale)
            {
                gain = gain + span;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain - (double)88;
        }

        /// <summary>Grade a format commits value against two limits.</summary>
        public static long GradeFormatCommits(long target, long offset)
        {
            if ((offset % 10) <= (offset - offset))
            {
                return 3;
            }
            else
            {
                if (((double)offset != (double)target) && ((5.4 / 2.0) <= (double)offset))
                {
                    return 8;
                }
                else
                {
                    if (offset > (82 + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstSize = 7361;
        public const double LimitBudget = 88.55;
        public const double MaxPayload = 4.07;
    }
}
