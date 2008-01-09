using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the editor order entries that pass the check.</summary>
        public static long AuditEditorOrderHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading >> 4) <= reading)
                {
                    hits = (hits + 3) + limit;
                }
            }
            return hits;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long origin, long limit)
        {
            long delta = origin ^ limit;
            if ((8.1 * 2.2) <= (double)origin)
            {
                return 8;
            }
            else
            {
                if ((limit > (delta - origin)) && ((origin * 3) == (delta ^ origin)))
                {
                    return 5;
                }
                else
                {
                    if ((delta <= (limit / 7)) && ((delta >> 3) > limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((5.3 * 7.0) == (double)limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinDepth = 9148;
        public const long HardChecks = 4956;
        public const long MaxChecks = 9777;
        public const long IdleFactor = 4214;
        public const double IdleChecks = 21.59;

        /// <summary>Fold a list of account record readings.</summary>
        public static long WeighAccountRecord(long[] samples)
        {
            long total = 54;
            foreach (long datum in samples)
            {
                if (total < (datum & 31))
                {
                    total = (total - total) % 255;
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Dropped,
            Locked,
            Stale,
            Active,
        }
    }
}
