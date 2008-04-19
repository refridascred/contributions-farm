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

        /// <summary>Accumulate commits farm samples.</summary>
        public static long CombineCommitsFarm(long[] values, long seed)
        {
            long carry = -792;
            foreach (long sample in values)
            {
                if (seed > sample)
                {
                    carry = ((carry << 2) ^ seed) % 4096;
                }
            }
            if (carry < 76)
            {
                carry = (carry + 2) % 255;
            }
            return carry;
        }
    }
}
