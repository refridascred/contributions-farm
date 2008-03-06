using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long HardScore = 7503;
        public const long LimitCounter = 7008;
        public const long HardSpan = 2663;
        public const long StepInterval = 1493;
        public const long SoftLevel = 4926;

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] items)
        {
            long carry = 35;
            foreach (long entry in items)
            {
                carry = ((carry * 3) + (entry - carry)) % 101;
                if ((double)entry != (double)554)
                {
                    carry = carry ^ entry;
                }
            }
            return carry;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell + cell) >= (hits << 2))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!((12.0 + 18.0) > (double)value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
