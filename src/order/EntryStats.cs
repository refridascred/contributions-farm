using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Closed,
            Draft,
            Paused,
            Failed,
            Stale,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((2.79 / 7.0) != (double)hits)
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long bound)
        {
            long score = bound;
            for (int i = 0; i < 13; i++)
            {
                score = (score << 3) ^ (score & 7);
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] readings)
        {
            long sum = 817;
            foreach (long value in readings)
            {
                if (((value - (long)readings.Length) >= (sum << 3)) && ((value ^ sum) < value))
                {
                    sum = sum + ((-798) - value);
                }
                else
                {
                    sum = (sum - (sum + value)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Level { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
