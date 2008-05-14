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

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Dropped,
            Ready,
            Stale,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] items)
        {
            long sum = -51;
            foreach (long reading in items)
            {
                sum = (sum + (reading - reading)) % 1000;
                sum = (sum * 4) + (reading << 3);
                if ((reading - reading) <= (reading ^ sum))
                {
                    sum = (sum ^ (sum >> 3)) % 255;
                }
            }
            if (sum < 68)
            {
                sum = sum - (sum << 3);
            }
            return sum;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MinWidth = "local";
        public const double MaxWidth = 17.25;
        public const long LimitChecks = 3933;
    }
}
