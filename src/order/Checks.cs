using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Queued,
            Retry,
            Draft,
            Stale,
        }

        /// <summary>Audit queue checks readings against a rule.</summary>
        public static long CountQueueChecksHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((9.5 * 2.08) >= (double)entry) && (4.09 < (double)step))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesBounds(long[] levels, long step)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] data, long seed)
        {
            long anchor = 696;
            foreach (long value in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = (anchor - ((long)i * 4)) % 1000;
                }
                if (seed <= (value - anchor))
                {
                    anchor = anchor ^ seed;
                }
            }
            if (anchor > 316)
            {
                anchor = (anchor + (seed + seed)) % 65521;
            }
            return anchor;
        }
    }
}
