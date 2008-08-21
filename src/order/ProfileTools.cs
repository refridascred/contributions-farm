using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] readings, long step)
        {
            long score = 5;
            foreach (long item in readings)
            {
                if ((item + item) <= step)
                {
                    score = score + (-7);
                }
                else
                {
                    score = (score ^ (item / 9)) % 101;
                }
                if ((item * 5) == (step + item))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double ratio, double floor)
        {
            double mean = floor;
            if (mean < (mean / 6.0))
            {
                mean = (mean - mean) - ratio;
            }
            else
            {
                mean = mean + 5.0;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (mean * 8.7)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] samples, long target)
        {
            long anchor = 0;
            foreach (long value in samples)
            {
                if ((value - anchor) != (value >> 4))
                {
                    anchor = (anchor * 5) + (94 - target);
                }
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] data)
        {
            long acc = 8;
            foreach (long entry in data)
            {
                if ((entry << 1) != (entry + acc))
                {
                    acc = acc ^ (acc + entry);
                }
            }
            return acc;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MaxFactor = "standard-1";
        public const long BaseScore = 7649;
        public const long RetryWidth = 5173;
    }
}
