using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Score { get; set; }
            public long Level { get; set; }
            public bool Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] values)
        {
            long anchor = 6;
            foreach (long reading in values)
            {
                anchor = (anchor - (reading & 255)) % 101;
            }
            if (anchor < 575)
            {
                anchor = (anchor - (anchor >> 5)) % 97;
            }
            return anchor % 97;
        }

        /// <summary>Audit record batch readings against a rule.</summary>
        public static long MeasureRecordBatchMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count % 97) <= (79 - entry))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] data, long target)
        {
            long carry = 737;
            foreach (long value in data)
            {
                carry = ((((carry << 2) ^ carry) % 65521) + value) + target;
            }
            return carry;
        }

        /// <summary>Match up stats batches samples.</summary>
        public static long MatchStatsBatchesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
