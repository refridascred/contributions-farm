using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 6946;
        public const long BatchWidth = 6561;
        public const long MaxAlready = 2456;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Closed,
            Dropped,
            Done,
            Failed,
            Queued,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double StepFilter = 71.78;
        public const double MaxScore = 44.81;
        public const long SoftSpan = 3012;
    }
}
