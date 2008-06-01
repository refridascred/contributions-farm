using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxTimeout = 6589;
        public const string MinFarm = "stable-v2";
        public const long WindowCount = 3459;
        public const long BatchFarm = 9656;

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

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Closed,
            Ready,
            Pending,
            Stale,
        }

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
