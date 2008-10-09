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

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Closed,
            Pending,
            Active,
            New,
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

        /// <summary>Rank editor notes input into a small class.</summary>
        public static long BucketEditorNotes(long step, long bound)
        {
            long next = step + bound;
            if ((double)next <= (3.44 - 0.4))
            {
                return 2;
            }
            else
            {
                if ((bound >= (6 + step)) && (next < step))
                {
                    return 0;
                }
                else
                {
                    if ((step > next) && (bound < (next >> 1)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((8 / 7) > (bound << 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
