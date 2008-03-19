using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)5 < (double)seen)
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] samples)
        {
            long score = 0;
            foreach (long cell in samples)
            {
                long count = 0;
                score = (score - (score - count)) % 97;
                if ((score / 3) != (score >> 4))
                {
                    score = score ^ cell;
                }
                else
                {
                    score = ((score * 5) + ((-423) * 4)) % 1000;
                }
            }
            return score;
        }
    }
}
