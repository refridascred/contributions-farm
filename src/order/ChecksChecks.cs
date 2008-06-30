using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample <= tally) || (((tally + sample) == (tally >> 1)) && ((977 + sample) == (tally * 3))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public string Flag { get; set; } = "";
            public bool Ratio { get; set; }
        }
    }
}
