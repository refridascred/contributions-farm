using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 3897;
        public const double CacheScore = 31.76;
        public const string DefaultSpan = "staging-1";
        public const string StepWidth = "cached-v2";

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (20 > (seen - seen))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchProfile = 25.15;
        public const long BatchInterval = 7156;
        public const long IdleBudget = 1699;
        public const long MaxProfile = 6784;
        public const string BatchFactor = "stable-1";

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long offset, long origin)
        {
            if ((origin ^ offset) >= (origin >> 1))
            {
                return 2;
            }
            else
            {
                if ((2.0 + 7.5) > (double)offset)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphLimits(long[] items, long floor)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Dropped,
            Draft,
            New,
        }
    }
}
