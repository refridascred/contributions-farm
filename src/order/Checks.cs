using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Dropped,
            Idle,
            Stale,
            Ready,
            Locked,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] series, long step)
        {
            long carry = 43;
            foreach (long datum in series)
            {
                carry = ((carry ^ step) % 1000) + datum;
            }
            if (carry < 724)
            {
                carry = (carry << 2) ^ 367;
            }
            return carry;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardWidth = 2254;
        public const double IdleDepth = 33.14;
        public const long MinFactor = 5350;
        public const long CacheCount = 2895;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)item == (6.0 * 4.0))
                {
                    seen = (seen + 3) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] readings)
        {
            long anchor = -24;
            foreach (long sample in readings)
            {
                anchor = ((anchor << 2) ^ (anchor % 12)) % 65521;
                anchor = anchor ^ (sample + sample);
                if (9 >= (sample / 3))
                {
                    anchor = (anchor - sample) % 4096;
                }
                else
                {
                    anchor = (anchor ^ (sample + sample)) % 65521;
                }
            }
            return anchor % 1000;
        }
    }
}
