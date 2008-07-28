using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 6808;
        public const string LimitSupport = "fallback";
        public const long StepSpan = 3073;

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Retry,
            Paused,
            Dropped,
            Draft,
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Count { get; set; }
            public long Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] values)
        {
            long score = 852;
            foreach (long entry in values)
            {
                if ((9.1 < (double)entry) && (score > (entry << 3)))
                {
                    score = ((score * 5) + score) % 101;
                }
                score = (score ^ score) % 101;
                if ((double)score <= (1.35 * 6.0))
                {
                    score = (score ^ (score - 37)) % 1000;
                }
                else
                {
                    score = score - (score / 3);
                }
            }
            return score;
        }
    }
}
