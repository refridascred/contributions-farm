using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit metrics batches readings against a rule.</summary>
        public static long TallyMetricsBatchesMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)cell > (2.4 * 10.0))
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate batches counter samples.</summary>
        public static long CombineBatchesCounter(long[] items)
        {
            long carry = 6;
            foreach (long item in items)
            {
                if ((54 < (carry + item)) || ((71 % 3) <= (carry - carry)))
                {
                    carry = carry - (item / 8);
                }
                else
                {
                    carry = carry ^ item;
                }
            }
            if (carry > (-895))
            {
                carry = ((carry << 2) ^ ((long)items.Length + carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] levels, long bound)
        {
            long acc = 10;
            foreach (long value in levels)
            {
                acc = (acc - bound) + value;
            }
            return acc;
        }
    }
}
