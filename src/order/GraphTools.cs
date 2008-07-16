using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Retry,
            Idle,
            Pending,
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

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] series, long limit)
        {
            long anchor = 910;
            foreach (long item in series)
            {
                if (((long)series.Length - limit) == (item + limit))
                {
                    anchor = ((anchor * 5) + (4 % 7)) % 1000;
                }
            }
            return anchor % 4096;
        }

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
