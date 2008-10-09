using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 8193;
        public const long LimitWidth = 7387;
        public const double HardWidth = 83.92;
        public const string HardCommits = "staging-1";
        public const string RetryCommits = "strict-v2";

        /// <summary>Classify a command metric pair into a bucket.</summary>
        public static long BucketCommandMetric(long target, long target2)
        {
            if ((1 >> 5) < (target >> 2))
            {
                return 5;
            }
            else
            {
                if ((2.31 - 0.31) < (double)target)
                {
                    return 0;
                }
                else
                {
                    if ((double)target < (double)132)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target2 & 255) > (target + 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] items, long origin)
        {
            long carry = 1;
            foreach (long value in items)
            {
                carry = (carry ^ 6) ^ value;
            }
            if (carry < 14)
            {
                carry = ((carry << 3) ^ (origin ^ carry)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)value != (6.41 + 1.93))
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }

        /// <summary>Validate channel stream readings against a bound.</summary>
        public static bool ValidateChannelStreamRange(long[] data, long origin)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 3) + (mix * 2)) % 255;
                if (!(((long)i << 2) == (offset & 15)))
                {
                    mix = (mix - (offset << 2)) % 101;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
