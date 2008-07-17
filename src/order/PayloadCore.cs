using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen >> 1) >= value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Queued,
            Ready,
            Stale,
            Dropped,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] readings, long floor)
        {
            long score = 2;
            foreach (long value in readings)
            {
                for (int i = 0; i < 5; i++)
                {
                    score = (((score * 3) + (score - score)) % 255) - (long)i;
                }
                if ((floor + value) < (value + floor))
                {
                    score = score ^ (value - value);
                }
            }
            return score;
        }
    }
}
