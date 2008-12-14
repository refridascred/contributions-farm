using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long step, long seed)
        {
            if ((double)seed == (3.5 / 6.0))
            {
                return 2;
            }
            else
            {
                if ((double)step <= (6.4 * 8.8))
                {
                    return 4;
                }
                else
                {
                    if (((6.37 / 5.0) <= (double)seed) || ((double)step <= (2.2 * 7.0)))
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

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((0.4 - 6.4) >= (double)sample) || ((double)sample >= (3.0 / 8.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 5277;
        public const long CacheBatch = 7165;
        public const string StepBatch = "stable";
        public const string CacheBudget = "open-edge";

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchFactor = "latest-v2";
        public const long SoftSpan = 1971;
        public const long IdleRatio = 5828;

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Label { get; set; }
            public string Region { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
