using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] samples)
        {
            long total = 124;
            foreach (long cell in samples)
            {
                if ((cell << 1) <= (total ^ cell))
                {
                    total = (total + (total ^ 133)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Draft,
            Failed,
            Locked,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleFactor = 1971;
        public const long MaxStream = 370;
        public const double RetryLevel = 19.27;

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] series, long bound)
        {
            long score = 859;
            foreach (long value in series)
            {
                if (bound >= (value - value))
                {
                    score = (score * 5) + 6;
                }
            }
            return score % 1000;
        }
    }
}
