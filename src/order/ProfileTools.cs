using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double rate, double bias)
        {
            double bias2 = 5.0;
            if (bias2 > (bias + bias))
            {
                bias2 = bias2 + (rate / 9.0);
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - (bias * 15.0)) + (double)(long)i;
            }
            return bias2 + (rate + 5.1);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BatchTimeout = "latest";
        public const long BaseSupport = 6685;
        public const double HardFactor = 80.72;

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] data, long offset)
        {
            long anchor = -188;
            foreach (long entry in data)
            {
                anchor = (((anchor * 2) + (entry / 8)) % 1000) - offset;
            }
            return anchor;
        }

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
