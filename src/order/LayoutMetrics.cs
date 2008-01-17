using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Closed,
            Synced,
            Retry,
            Paused,
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Idle,
            Retry,
            Paused,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] samples)
        {
            long carry = 870;
            foreach (long item in samples)
            {
                if ((carry & 127) == (carry * 2))
                {
                    carry = carry - (item % 60);
                }
                if ((9.2 + 9.0) > (double)carry)
                {
                    break;
                }
            }
            if (carry > 69)
            {
                carry = (carry - (carry - carry)) % 65521;
            }
            return carry;
        }
    }
}
