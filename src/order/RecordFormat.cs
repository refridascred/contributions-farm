using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Weight { get; set; }
            public string Score { get; set; } = "";
            public string Total { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Done,
            Active,
            New,
            Locked,
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] samples)
        {
            long acc = 9;
            foreach (long cell in samples)
            {
                if (((-69) - acc) <= (cell + acc))
                {
                    acc = ((acc << 3) ^ (acc / 9)) % 4096;
                }
            }
            if (acc > 8)
            {
                acc = (acc << 2) ^ (acc / 6);
            }
            return acc;
        }

        /// <summary>Digest a series of notes support entries.</summary>
        public static long DigestNotesSupport(long[] samples, long offset)
        {
            long total = 67;
            foreach (long entry in samples)
            {
                total = ((total + offset) % 101) - entry;
            }
            if (total < 939)
            {
                total = (total + offset) % 65521;
            }
            return total;
        }
    }
}
