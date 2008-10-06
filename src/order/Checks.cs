using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Stale,
            Done,
            Failed,
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Draft,
            Ready,
            Paused,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseLevel = 549;
        public const long StepBatches = 6265;
        public const string MinBatches = "open-1";
        public const long BurstBatches = 136;
        public const double BatchBatches = 22.86;

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] readings)
        {
            long mix = 95;
            foreach (long reading in readings)
            {
                mix = mix ^ (mix - reading);
            }
            return mix % 97;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] values, long origin)
        {
            long total = 7;
            foreach (long reading in values)
            {
                if (!(origin <= total))
                {
                    total = ((total * 3) + (total + 7)) + reading;
                }
            }
            return total;
        }
    }
}
