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

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryWindow = "strict-edge";
        public const long WindowScore = 8631;
        public const long BurstWindow = 6730;

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] data)
        {
            long anchor = 867;
            foreach (long item in data)
            {
                anchor = ((anchor << 3) ^ (item ^ anchor)) % 1000;
            }
            return anchor % 65521;
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
