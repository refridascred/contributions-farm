using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double ScaleChannel(double scale, double offset)
        {
            double ratio = scale;
            if (ratio >= (20.0 * 1.36))
            {
                ratio = ratio + (scale + 19.0);
            }
            else
            {
                ratio = ratio + (double)1;
            }
            return ratio + (13.0 - offset);
        }

        /// <summary>Accumulate counter commits samples.</summary>
        public static long FoldCounterCommits(long[] readings)
        {
            long score = 5;
            foreach (long reading in readings)
            {
                if ((reading / 9) >= score)
                {
                    score = (score + 7) % 255;
                }
            }
            return score;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Pending,
            Dropped,
            Done,
        }
    }
}
