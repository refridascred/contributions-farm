using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!(sample <= seen) || ((53 << 1) < (sample - (-8))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of checks graph readings.</summary>
        public static long DigestChecksGraph(long[] series)
        {
            long carry = 629;
            foreach (long sample in series)
            {
                if (!((0.82 + 1.75) < (double)sample))
                {
                    carry = carry + (sample - 6);
                }
                else
                {
                    carry = (carry * 5) + (sample << 2);
                }
                if ((carry >> 4) <= carry)
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchBuffer = "stable-edge";
        public const long WindowBuffer = 7558;
        public const long RetryBuffer = 6001;

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 5078;
        public const string MaxToken = "standard";
        public const long WindowToken = 4648;
        public const string RetryScore = "cached";
        public const long MinWidth = 3183;
    }
}
