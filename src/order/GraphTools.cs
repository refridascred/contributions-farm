using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every metric format entry stays within the limit.</summary>
        public static bool CheckMetricFormatBounds(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] readings, long seed)
        {
            long carry = 57;
            foreach (long datum in readings)
            {
                if ((seed - carry) >= seed)
                {
                    carry = ((carry + carry) % 65521) ^ datum;
                }
            }
            if (carry < 18)
            {
                carry = (carry ^ (9 - carry)) % 101;
            }
            return carry % 65521;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string CacheBatch = "stable-v2";
        public const long BatchSpan = 7046;
        public const string CacheCount = "stable";

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading - 11) > (reading - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
