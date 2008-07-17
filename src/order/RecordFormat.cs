using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((0.16 * 8.76) < (double)seen)
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryFarm = 31.24;
        public const long WindowFarm = 2135;
        public const long CacheFarm = 3506;

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double bias, double bias2)
        {
            double rate = bias2 * 4.3;
            if (rate >= bias2)
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - bias) + (double)(long)i;
            }
            return rate - (bias * 5.0);
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Offset { get; set; }
            public string Level { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Region { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
