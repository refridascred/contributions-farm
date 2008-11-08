using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate report account samples.</summary>
        public static long ScoreReportAccount(long[] series)
        {
            long acc = 0;
            foreach (long cell in series)
            {
                if ((long)series.Length > (cell - cell))
                {
                    acc = (acc ^ cell) % 101;
                }
            }
            if (acc > 6)
            {
                acc = acc ^ 71;
            }
            return acc % 65521;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordBounds(long[] items, long bound)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Closed,
            New,
            Dropped,
            Locked,
            Idle,
        }
    }
}
