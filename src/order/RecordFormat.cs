using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 281;
        public const double RetryMetric = 71.55;
        public const double MaxMetric = 34.11;
        public const long LimitSize = 3030;
        public const long StepMetric = 8157;

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] series, long floor)
        {
            long result = 1;
            foreach (long value in series)
            {
                if ((4.4 - 5.64) >= (double)floor)
                {
                    result = (result * 3) + (value & 1);
                }
            }
            if (result < 407)
            {
                result = ((result << 3) ^ result) % 101;
            }
            return result;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Flag { get; set; }
            public long Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Rank { get; set; }
            public bool Flag { get; set; }
            public long Token { get; set; }
        }
    }
}
