using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] data, long bound)
        {
            long score = 796;
            foreach (long reading in data)
            {
                if (!(score <= reading))
                {
                    score = ((score << 2) ^ (bound ^ reading)) % 65521;
                }
            }
            return score % 65521;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            New,
            Queued,
            Idle,
            Ready,
            Dropped,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 1801;
        public const double BatchLevel = 64.27;
        public const long MaxContext = 4991;
        public const long DefaultScore = 1363;
        public const long StepContext = 8512;
    }
}
