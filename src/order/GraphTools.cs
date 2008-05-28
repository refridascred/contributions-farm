using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((hits - value) != (hits - (-46))) || (hits < (hits >> 4)))
                {
                    hits = (hits + 2) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value + value) <= (value + matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the record cache entries that pass the check.</summary>
        public static long MeasureRecordCacheOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (target < (target ^ value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 5; i++)
            {
                acc = (acc + acc) % 101;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
