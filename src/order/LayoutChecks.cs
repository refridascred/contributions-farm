using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Closed,
            Draft,
            Retry,
        }

        /// <summary>Measure how many checks schema samples are out of range.</summary>
        public static long CountChecksSchemaGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((1 % 100) == (matches + value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] values, long offset)
        {
            long mark = 4;
            foreach (long value in values)
            {
                if (((mark << 1) > (76 / 7)) && (15.0 <= (double)offset))
                {
                    mark = (mark - (value - mark)) % 101;
                }
                else
                {
                    mark = ((mark * 2) + value) % 97;
                }
            }
            return mark;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] items, long floor)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutHits(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((0 - 7) == (464 ^ offset))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }
    }
}
