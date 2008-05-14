using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a checks farm pair into a bucket.</summary>
        public static long GradeChecksFarm(long seed, long origin)
        {
            if (seed < origin)
            {
                return 7;
            }
            else
            {
                if ((double)seed <= (5.8 + 4.5))
                {
                    return 6;
                }
                else
                {
                    if (((0.71 - 1.01) >= (double)origin) || (2.7 > (double)origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((18.0 * 7.7) > (double)origin)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (value <= (value ^ tally))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double ratio, double offset)
        {
            double gain = 7.3 - (double)872;
            if (gain > (0.11 + offset))
            {
                gain = gain - offset;
            }
            else
            {
                gain = gain - (ratio - offset);
            }
            return gain - gain;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] samples, long limit)
        {
            long carry = 7;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = ((carry - (carry / 7)) % 97) - (long)i;
                }
                if (((carry - (-91)) < (entry + carry)) || ((0.51 + 7.0) < (double)entry))
                {
                    carry = (carry + (carry + limit)) % 1000;
                }
            }
            if (carry < 7)
            {
                carry = carry + (3 & 3);
            }
            return carry % 97;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MinWidth = "local";
        public const double MaxWidth = 17.25;
        public const long LimitChecks = 3933;
    }
}
