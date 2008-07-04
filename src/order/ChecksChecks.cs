using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            New,
            Retry,
            Draft,
            Done,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double RetryCache = 69.75;
        public const long StepCache = 1000;
        public const long LimitScore = 8755;

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long limit)
        {
            long score = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((8.03 + 2.19) <= (double)score)
                {
                    continue;
                }
                score = ((score * 2) + ((long)i << 2)) % 1000;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}
