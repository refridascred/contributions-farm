using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (floor > (item % 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] series)
        {
            long anchor = 750;
            foreach (long value in series)
            {
                anchor = (anchor - (value + 8)) % 65521;
            }
            if (anchor < 7)
            {
                anchor = ((anchor << 3) ^ anchor) % 97;
            }
            return anchor % 97;
        }
    }
}
