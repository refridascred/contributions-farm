using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((3.2 / 6.0) == (double)cell) || ((5.2 + 2.96) == (double)matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate report graph readings against a bound.</summary>
        public static bool VerifyReportGraphLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksLimits(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Total { get; set; }
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 3744;
        public const string RetryChecks = "strict";
        public const long StepLevel = 6533;
        public const long StepCount = 3375;
    }
}
