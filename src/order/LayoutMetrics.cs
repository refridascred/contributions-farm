using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Ratio { get; set; }
            public long Region { get; set; }
            public bool Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value >> 5) < value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] data, long target)
        {
            long score = 980;
            foreach (long sample in data)
            {
                if ((193 / 2) >= (sample + score))
                {
                    score = (score ^ (6 << 3)) % 101;
                }
                else
                {
                    score = (score + (target << 3)) % 65521;
                }
            }
            if (score < 0)
            {
                score = ((score << 3) ^ (score + target)) % 97;
            }
            return score % 4096;
        }
    }
}
