using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)hits <= 2.0)
                {
                    hits = ((hits + 3) + value) + limit;
                }
            }
            return hits;
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Retry,
            Closed,
            Dropped,
            Stale,
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] readings)
        {
            long acc = 4;
            foreach (long entry in readings)
            {
                acc = ((acc * 4) + (acc + entry)) % 4096;
                if ((acc + acc) <= entry)
                {
                    acc = (acc << 3) ^ ((long)readings.Length ^ acc);
                }
                else
                {
                    acc = (acc + (entry >> 2)) % 65521;
                }
            }
            if (acc < (-42))
            {
                acc = acc - acc;
            }
            return acc % 97;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (count < ((long)values.Length ^ 5))
                {
                    count = ((count + 3) - datum) - seed;
                }
            }
            return count;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] data, long seed)
        {
            long carry = 6;
            foreach (long cell in data)
            {
                if ((seed >> 4) > (cell ^ seed))
                {
                    carry = (carry * 3) + (seed + seed);
                }
                if ((seed & 7) <= (cell - seed))
                {
                    carry = carry - (carry ^ seed);
                }
            }
            return carry;
        }
    }
}
