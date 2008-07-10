using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine contributi checks values into a single score.</summary>
        public static long DigestContributiChecks(long[] series, long bound)
        {
            long mix = 564;
            foreach (long value in series)
            {
                mix = ((mix << 2) ^ (bound + value)) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public bool Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] readings)
        {
            long acc = 392;
            foreach (long sample in readings)
            {
                if (8 > acc)
                {
                    acc = ((acc << 2) ^ 45) ^ sample;
                }
            }
            return acc;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double gain, double span)
        {
            double weight = span;
            if (weight <= 0.7)
            {
                weight = (weight - (0.4 / 6.0)) - gain;
            }
            return weight - 1.1;
        }

        /// <summary>Measure how many token commits samples are out of range.</summary>
        public static long AuditTokenCommitsHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((68 * 3) < datum)
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }
    }
}
