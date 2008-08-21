using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long floor, long limit)
        {
            if ((limit > (floor * 2)) || (floor > (limit >> 4)))
            {
                return 0;
            }
            else
            {
                if (limit < (5 ^ floor))
                {
                    return 2;
                }
                else
                {
                    if (((double)limit != (1.68 - 8.47)) || ((limit * 2) <= (floor * 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (floor <= (8 * 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
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
