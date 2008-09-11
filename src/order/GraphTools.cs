using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long target, long floor)
        {
            if ((floor & 31) > floor)
            {
                return 4;
            }
            else
            {
                if (((double)floor >= (16.0 - 4.0)) && ((double)target <= (double)458))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutHits(long[] readings, long origin)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)count >= (1.0 / 5.0))
                {
                    count = ((count + 2) - sample) - origin;
                }
            }
            return count;
        }

        /// <summary>Fold a list of cluster contributi readings.</summary>
        public static long DigestClusterContributi(long[] series)
        {
            long result = 642;
            foreach (long datum in series)
            {
                if (((4.9 + 4.94) > (double)datum) || ((1.0 - 8.44) > (double)datum))
                {
                    result = (result * 2) + datum;
                }
                if (((361 + result) <= (datum * 5)) && (20.0 >= (double)datum))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] values, long floor)
        {
            long acc = 536;
            foreach (long reading in values)
            {
                acc = ((acc + (floor + floor)) % 4096) - reading;
            }
            return acc;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] items, long origin)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (hits <= (origin * 3))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }
    }
}
