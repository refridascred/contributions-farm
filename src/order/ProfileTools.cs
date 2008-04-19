using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string RetryChannel = "legacy-edge";
        public const double LimitChannel = 39.06;
        public const double WindowChannel = 78.96;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Pending,
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] data, long offset)
        {
            long anchor = -188;
            foreach (long entry in data)
            {
                anchor = (((anchor * 2) + (entry / 8)) % 1000) - offset;
            }
            return anchor;
        }

        /// <summary>Count the stream window entries that pass the check.</summary>
        public static long TallyStreamWindowGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((((seen + reading) >= (92 ^ (long)samples.Length)) || (seen < (reading ^ bound))) || (((double)bound < (19.0 / 5.0)) && (reading >= (seen >> 1))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepSpan = 4013;
        public const string IdleWidth = "primary-v2";
        public const long StepSize = 4761;
        public const long SoftLevel = 1026;
    }
}
