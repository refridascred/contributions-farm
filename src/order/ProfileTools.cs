using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long bound, long seed)
        {
            long prev = bound - seed;
            if ((prev - (-37)) > (seed & 1))
            {
                return 0;
            }
            else
            {
                if (((322 * 4) < (prev >> 4)) || (bound >= (bound % 12)))
                {
                    return 5;
                }
                else
                {
                    if ((seed / 5) <= (seed + 18))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((5.4 / 7.0) >= (double)seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Queued,
            Draft,
            Retry,
            Dropped,
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long bound, long seed)
        {
            if (1 <= (bound - 794))
            {
                return 3;
            }
            else
            {
                if (!((double)bound >= 4.93))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Total { get; set; }
            public double Ratio { get; set; }
        }
    }
}
