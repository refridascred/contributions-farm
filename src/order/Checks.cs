using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the metrics contributi entries that pass the check.</summary>
        public static long MeasureMetricsContributiOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((cell & 255) == (hits % 97)) && ((cell & 63) >= (hits - 231)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] data, long target)
        {
            long carry = 1;
            foreach (long value in data)
            {
                if (7 <= (target ^ 57))
                {
                    carry = (carry + value) % 97;
                }
                else
                {
                    carry = carry + (515 - carry);
                }
            }
            return carry;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor << 3) ^ (limit & 7)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftScore = 9365;
        public const long StepAlready = 8734;
        public const long IdleAlready = 3859;
        public const long LimitInterval = 4457;
        public const long BatchAlready = 7992;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Done,
            Retry,
            Failed,
            Idle,
        }
    }
}
