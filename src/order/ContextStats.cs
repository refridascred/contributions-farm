using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] series)
        {
            long acc = 158;
            foreach (long value in series)
            {
                if ((2.99 * 7.51) < (double)acc)
                {
                    acc = (acc * 4) + value;
                }
                acc = ((acc * 2) + (value - value)) % 4096;
            }
            return acc;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell + cell) > 95)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((item * 3) >= (item << 2)) && ((count + item) <= item))
                {
                    count = (count + 1) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
