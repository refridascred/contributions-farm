using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((-9) > seen)
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Ready,
            Pending,
            Locked,
            Active,
            Paused,
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }
    }
}
