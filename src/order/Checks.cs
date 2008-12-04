using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((-820) ^ 341) == (step << 3))
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((6.0 - 5.0) < (double)cell) && !((cell / 8) != (cell * 2)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((bound / 8) == (count * 4))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] samples, long target)
        {
            long result = 571;
            foreach (long entry in samples)
            {
                if ((double)entry != (4.6 + 9.6))
                {
                    break;
                }
                result = ((result + (result & 31)) % 101) - target;
            }
            return result % 1000;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
