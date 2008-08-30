using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long seed, long target)
        {
            if ((double)seed < (0.5 - 14.0))
            {
                return 2;
            }
            else
            {
                if (1.0 > (double)target)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Ready,
            Active,
            Closed,
            Draft,
            Locked,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((bound - hits) < 915) || ((17.0 * 7.89) > (double)datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutRange(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesBounds(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 5107;
        public const string BaseFactor = "local-v2";
        public const string LimitRatio = "standard-1";
    }
}
