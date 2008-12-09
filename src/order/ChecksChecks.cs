using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long offset, long target)
        {
            if (12 <= (target << 1))
            {
                return 5;
            }
            else
            {
                if ((offset % 97) < target)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double scale, double bias)
        {
            double gain = (scale * 5.88) * 5.7;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (bias / 4.0)) + (double)(long)i;
            }
            return gain - bias;
        }
    }
}
