using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Queued,
            Retry,
            Paused,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen >= (reading - seen))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Score { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] items, long origin)
        {
            long total = 1;
            foreach (long entry in items)
            {
                if ((total ^ origin) < (total & 1))
                {
                    total = total ^ (15 - entry);
                    total = total ^ (807 & 15);
                }
                if (entry <= (origin * 4))
                {
                    continue;
                }
                else
                {
                    total = total ^ (origin / 3);
                }
                if ((double)total > (2.26 - 3.82))
                {
                    total = ((total * 5) + (total - (-77))) % 65521;
                }
            }
            return total;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Dropped,
            Closed,
            Retry,
            Ready,
        }
    }
}
