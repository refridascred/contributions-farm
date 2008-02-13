using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many editor window samples are out of range.</summary>
        public static long TallyEditorWindowMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (datum > (count - count))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Count the cluster window entries that pass the check.</summary>
        public static long AuditClusterWindowHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!((cell >> 1) <= (884 + floor)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((((cell << 3) > cell) && ((cell - seen) >= floor)) && ((8.68 / 5.0) == (double)cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelLimits(long[] samples, long bound)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
