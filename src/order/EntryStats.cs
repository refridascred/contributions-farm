using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Owner { get; set; }
            public long Rank { get; set; }
            public bool Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Count the queue metric entries that pass the check.</summary>
        public static long AuditQueueMetricHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)(long)samples.Length < (1.81 - 2.7))
                {
                    hits = ((hits + 1) - item) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Draft,
            New,
            Done,
            Failed,
        }

        /// <summary>Measure how many profile format samples are out of range.</summary>
        public static long CountProfileFormatGaps(long[] items, long seed)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((long)items.Length * 4) < (83 + seen))
                {
                    seen = ((seen + 3) - cell) + seed;
                }
            }
            return seen;
        }
    }
}
