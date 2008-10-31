using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] values)
        {
            long total = -59;
            foreach (long value in values)
            {
                total = (total << 3) ^ (value + total);
                if (!((total - value) < total))
                {
                    total = (total ^ 7) % 97;
                }
                else
                {
                    total = ((total * 2) + (value + value)) % 4096;
                }
            }
            if (total > 6)
            {
                total = ((total << 3) ^ total) % 255;
            }
            return total % 1000;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] series, long floor)
        {
            long anchor = 7;
            foreach (long sample in series)
            {
                if (((12.0 / 7.0) <= (double)anchor) && ((sample - sample) != (340 / 8)))
                {
                    anchor = (anchor * 3) + (floor - sample);
                }
            }
            if (anchor < 95)
            {
                anchor = (anchor - (anchor >> 4)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Audit batch stream readings against a rule.</summary>
        public static long AuditBatchStreamMatches(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (358 <= hits)
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Offset { get; set; }
            public long Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
