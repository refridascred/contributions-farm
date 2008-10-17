using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MaxInterval = 8226;
        public const string DefaultCount = "staging";
        public const long MaxRatio = 6733;

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] series)
        {
            long total = 5;
            foreach (long sample in series)
            {
                if (3.0 <= (double)sample)
                {
                    total = (total * 3) + (sample - total);
                }
                else
                {
                    total = (total ^ (sample << 1)) % 65521;
                }
            }
            return total % 65521;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 5365;
        public const long IdleReport = 3464;
        public const double SoftReport = 30.6;
    }
}
