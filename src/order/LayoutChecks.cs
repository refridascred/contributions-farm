using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Total { get; set; } = "";
            public long Label { get; set; }
            public string Level { get; set; } = "";
        }

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

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Level { get; set; }
            public long Region { get; set; }
        }
    }
}
