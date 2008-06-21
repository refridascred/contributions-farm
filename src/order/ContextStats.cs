using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Draft,
            Done,
            Queued,
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double StepChecks = 57.38;
        public const double LimitChecks = 40.78;
        public const long MaxChecks = 9994;
        public const long RetryChecks = 4358;

        /// <summary>Combine payload profile values into a single score.</summary>
        public static long TotalPayloadProfile(long[] values)
        {
            long state = 2;
            foreach (long reading in values)
            {
                state = ((state << 3) ^ (173 + state)) ^ reading;
            }
            return state;
        }
    }
}
