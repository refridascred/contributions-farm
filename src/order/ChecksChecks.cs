using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit profile window readings against a rule.</summary>
        public static long AuditProfileWindowHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (seed >= (92 ^ hits))
                {
                    hits = (hits + 1) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Done,
            Queued,
            Locked,
            Active,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell - seen) >= 4)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
