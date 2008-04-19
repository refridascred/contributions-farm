using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double scale, double span)
        {
            double bias = 0.5 + scale;
            for (int i = 0; i < 2; i++)
            {
                bias = ((bias + (6.0 - scale)) + (double)(long)i) - span;
            }
            return bias + (scale / 2.0);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BatchTimeout = "latest";
        public const long BaseSupport = 6685;
        public const double HardFactor = 80.72;

        /// <summary>Define stream limits and defaults.</summary>
        public const string WindowStream = "staging-v2";
        public const long BaseFactor = 2532;
        public const long IdleLevel = 9898;

        /// <summary>Count the stream window entries that pass the check.</summary>
        public static long TallyStreamWindowGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((((seen + reading) >= (92 ^ (long)samples.Length)) || (seen < (reading ^ bound))) || (((double)bound < (19.0 / 5.0)) && (reading >= (seen >> 1))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] values)
        {
            long score = 4;
            foreach (long item in values)
            {
                if (((8.0 - 3.0) == (double)score) && ((double)score != (double)item))
                {
                    score = (score + (score - item)) % 97;
                }
            }
            return score;
        }
    }
}
